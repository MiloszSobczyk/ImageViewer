using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace ImageViewer
{
    public struct ColorProfile
    {
        // perhaps it is neccessary to consider predefined illuminants of each color space
        public string name;
        public string illuminant;
        public double Y;
        public double gamma;
        public double whiteX;
        public double whiteY;
        public double redX;
        public double redY;
        public double greenX;
        public double greenY;
        public double blueX;
        public double blueY;
        public static Dictionary<string, Matrix<double>> bradfordMatrices = new Dictionary<string, Matrix<double>>()
        {
            {
                "D65ToD50",
                DenseMatrix.OfArray(new double[,]
                {
                    { 1.0478, 0.0229, -0.0501 },
                    { 0.0295, 0.9905, -0.0171 },
                    { -0.0092, 0.0150, 0.7521 },
                })
            },
            {
                "D50ToD65",
                DenseMatrix.OfArray(new double[,]
                {
                    { 0.9956, -0.0230, 0.0632 },
                    { -0.0283, 1.0099, 0.0210 },
                    { 0.0123, -0.0205, 1.3299 },
                })
            }
        };
        public static Dictionary<string, ColorProfile> GenerateProfiles()
        {
            Dictionary<string, ColorProfile> profiles = new Dictionary<string, ColorProfile>()
            {
                { "Custom", new ColorProfile() { name = "Custom", illuminant = "D65", Y = 1.0, gamma = 2.2, whiteX = 0.3127, whiteY = 0.3290, 
                    redX = 0.64, redY = 0.33, greenX = 0.3, greenY = 0.6, blueX = 0.15, blueY = 0.06 } },
                { "sRGB", new ColorProfile() { name = "sRGB", illuminant = "D65", Y = 1.0, gamma = 2.2, whiteX = 0.3127, whiteY = 0.3290, 
                    redX = 0.64, redY = 0.33, greenX = 0.3, greenY = 0.6, blueX = 0.15, blueY = 0.06 } },
                { "AdobeRGB", new ColorProfile() { name = "AdobeRGB", illuminant = "D65", Y = 1.0, gamma = 2.2, whiteX = 0.3127, whiteY = 0.3290, 
                    redX = 0.64, redY = 0.33, greenX = 0.21, greenY = 0.71, blueX = 0.15, blueY = 0.06 } },
                { "AppleRGB", new ColorProfile() { name = "AppleRGB", illuminant = "D65", Y = 1.0, gamma = 2.2, whiteX = 0.3127, whiteY = 0.3290, 
                    redX = 0.625, redY = 0.34, greenX = 0.28, greenY = 0.595, blueX = 0.155, blueY = 0.07 } },
                { "WideGamut", new ColorProfile() { name = "WideGamut", illuminant = "D50", Y = 1.0, gamma = 1.2, whiteX = 0.3456, whiteY = 0.3585, 
                    redX = 0.7347, redY = 0.2653, greenX = 0.1152, greenY = 0.8264, blueX = 0.1566, blueY = 0.0177 } },
            };
            return profiles;
        }
    }
    public class Converter
    {
        public Bitmap? sourceImage;
        public Bitmap? convertedImage;
        public Bitmap? grayedSourceImage;
        public Bitmap? grayedConvertedImage;

        private double eps = 1e-5;
        public void UploadImage(Bitmap? sourceImage)
        {
            if (this.sourceImage != null) this.sourceImage.Dispose();
            if (this.convertedImage != null) this.convertedImage.Dispose();
            this.sourceImage = sourceImage;
            this.convertedImage = null;
        }
        public Vector<double> Convert(int x = 215, int y = 35, int z = 67)
        {
            Matrix<double> matrix = DenseMatrix.OfArray(new double[,]
            {
                { 0.4124, 0.3576, 0.1805 },
                { 0.2126, 0.7152, 0.0722 },
                { 0.0193, 0.1192, 0.9505 },
            });
            Vector<double> vector = Vector<double>.Build.DenseOfArray(new double[] { x, y, z });
            vector = vector.Divide(255);
            vector = vector.PointwisePower(2.2);
            vector = matrix * vector;
            ConvertBack(vector, matrix);
            return vector;
        }

        public Vector<double> ConvertBack(Vector<double> XYZ, Matrix<double> reverse)
        {
            Matrix<double> matrix = reverse.Inverse();
            Vector<double> vector = XYZ;
            vector = matrix * vector;
            vector = vector.PointwisePower(1 / 2.2);
            vector *= 255;
            return vector;
        }

        public void Convert(ColorProfile sourceProfile, ColorProfile resultProfile)
        {
            if(sourceProfile.Equals(resultProfile))
            {
                convertedImage = sourceImage;
                return;
            }

            // var bradfordMatrix = CalculateBradfordMatrix(sourceProfile, resultProfile);
            var bradfordMatrix = sourceProfile.illuminant == resultProfile.illuminant ? DenseMatrix.CreateIdentity(3)
                : ColorProfile.bradfordMatrices[$"{sourceProfile.illuminant}To{resultProfile.illuminant}"];

            Matrix<double> sourceToXYZ = CalculateConversionMatrix(sourceProfile);
            Matrix<double> resultToXYZ = CalculateConversionMatrix(resultProfile);
            Matrix<double> XYZToResult = resultToXYZ.Inverse();

            convertedImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for(int i = 0; i < sourceImage.Width; ++i)
            {
                for(int j = 0; j < sourceImage.Height; ++j)
                {
                    Color pixel = sourceImage.GetPixel(i, j);
                    Vector<double> pixelVector = Vector<double>.Build.DenseOfArray(new double[]
                        { pixel.R, pixel.G, pixel.B });
                    pixelVector = pixelVector.Divide(255);
                    pixelVector = pixelVector.PointwisePower(sourceProfile.gamma);
                    pixelVector = sourceToXYZ * pixelVector;

                    pixelVector = bradfordMatrix * pixelVector;
                    pixelVector = XYZToResult * pixelVector;
                    pixelVector = pixelVector.PointwisePower(1 / resultProfile.gamma);
                    pixelVector = pixelVector.Multiply(255);
                    bool convertible = pixelVector.All(x => x >= -eps && x <= 255 + eps);
                    Color convertedColor = Color.Black;
                    if(pixelVector.All(x => x >= -eps && x <= 255 + eps))
                    {
                        int R = (int)pixelVector[0];
                        if (R == -1) R = 0;
                        int G = (int)pixelVector[1];
                        int B = (int)pixelVector[2];
                        convertedColor = Color.FromArgb(R, G, B);
                    }
                    convertedImage.SetPixel(i, j, convertedColor);
                }
            }

        }
        public Matrix<double> CalculateConversionMatrix(ColorProfile profile)
        {
            Vector<double> XYZ = CalculateXYZ(profile);
            Matrix<double> profileMatrix = CalculateProfileMatrix(profile);
            Matrix<double> inverseProfileMatrix = profileMatrix.Inverse();

            Vector<double> S = inverseProfileMatrix * XYZ;

            Matrix<double> conversionMatrix = DenseMatrix.OfArray(new double[,]
            {
                { profileMatrix[0, 0] * S[0], profileMatrix[0, 1] * S[1], profileMatrix[0, 2] * S[2] },
                { profileMatrix[1, 0] * S[0], profileMatrix[1, 1] * S[1], profileMatrix[1, 2] * S[2] },
                { profileMatrix[2, 0] * S[0], profileMatrix[2, 1] * S[1], profileMatrix[2, 2] * S[2] },
            });
            return conversionMatrix;
        }
        public Matrix<double> CalculateProfileMatrix(ColorProfile profile)
        {
            return DenseMatrix.OfArray(new double[,]
            {
                { profile.redX, profile.greenX, profile.blueX },
                { profile.redY, profile.greenY, profile.blueY },
                { 1 - profile.redX - profile.redY, 1 - profile.greenX - profile.greenY, 1 - profile.blueX - profile.blueY },
            });
        }
        public Vector<double> CalculateXYZ(ColorProfile profile)
        {
            double Y = profile.Y;
            double X = profile.whiteX * (Y / profile.whiteY);
            double Z = (1 - profile.whiteX - profile.whiteY) * (Y / profile.whiteY);
            return Vector<double>.Build.DenseOfArray(new double[] { X, Y, Z });
        }
        public Matrix<double> CalculateBradfordMatrix(ColorProfile sourceProfile, ColorProfile resultProfile)
        {
            Matrix<double> temp = DenseMatrix.OfArray(new double[,]
            {
                { 0.8951, 0.2664, -0.1614 },
                { -0.7502, 1.7135, 0.0367 },
                { 0.0389, -0.0685, 1.0296 },
            });

            Vector<double> sourceWhiteXYZ = CalculateXYZ(sourceProfile);
            Vector<double> resultWhiteXYZ = CalculateXYZ(resultProfile);

            Vector<double> tempSourceWhiteRGB = temp * sourceWhiteXYZ;
            Vector<double> tempResultWhiteRGB = temp * resultWhiteXYZ;

            Matrix<double> whiteProportions = DenseMatrix.OfArray(new double[,]
            {
                { tempResultWhiteRGB[0] /  tempSourceWhiteRGB[0], 0, 0 },
                { 0, tempResultWhiteRGB[1] /  tempSourceWhiteRGB[1], 0 },
                { 0, 0, tempResultWhiteRGB[2] /  tempSourceWhiteRGB[2] },
            });

            Matrix<double> bradfordMatrix = temp * whiteProportions * temp;
            return bradfordMatrix;
        }
        public void ConvertToGray()
        {
            if (sourceImage == null) return;
            grayedSourceImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for(int i = 0; i < grayedSourceImage.Width; ++i)
            {
                for(int j = 0; j < grayedSourceImage.Height; ++j)
                {
                    Color pixelColor = sourceImage.GetPixel(i, j);
                    int grayValue = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);
                    grayedSourceImage.SetPixel(i, j, Color.FromArgb(grayValue, grayValue, grayValue));
                }
            }
        }
    }
}
