using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
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
        public double gamma;
        public double whiteX;
        public double whiteY;
        public double redX;
        public double redY;
        public double greenX;
        public double greenY;
        public double blueX;
        public double blueY;
        public static Dictionary<string, ColorProfile> GenerateProfiles()
        {
            Dictionary<string, ColorProfile> profiles = new Dictionary<string, ColorProfile>()
            {
                { "Custom", new ColorProfile() { name = "Custom", gamma = 2.2, whiteX = 0.3127, whiteY = 0.3290,
                    redX = 0.64, redY = 0.33, greenX = 0.3, greenY = 0.6, blueX = 0.15, blueY = 0.06 } },
                { "sRGB", new ColorProfile() { name = "sRGB", gamma = 2.2, whiteX = 0.3127, whiteY = 0.3290,
                    redX = 0.64, redY = 0.33, greenX = 0.3, greenY = 0.6, blueX = 0.15, blueY = 0.06 } },
                { "AdobeRGB", new ColorProfile() { name = "AdobeRGB", gamma = 2.2, whiteX = 0.3127, whiteY = 0.3290,
                    redX = 0.64, redY = 0.33, greenX = 0.21, greenY = 0.71, blueX = 0.15, blueY = 0.06 } },
                { "AppleRGB", new ColorProfile() { name = "AppleRGB", gamma = 2.2, whiteX = 0.3127, whiteY = 0.3290,
                    redX = 0.625, redY = 0.34, greenX = 0.28, greenY = 0.595, blueX = 0.155, blueY = 0.07 } },
                { "CIERGB", new ColorProfile() { name = "CIERGB", gamma = 2.2, whiteX = 0.3333, whiteY = 0.3333,
                    redX = 0.735, redY = 0.265, greenX = 0.274, greenY = 0.717, blueX = 0.167, blueY = 0.007 } },
                { "WideGamut", new ColorProfile() { name = "WideGamut", gamma = 1.2, whiteX = 0.3456, whiteY = 0.3585,
                    redX = 0.7347, redY = 0.2653, greenX = 0.1152, greenY = 0.8264, blueX = 0.1566, blueY = 0.0177 } },
            };
            return profiles;
        }
    }
    public class Converter
    {
        public Bitmap? sourceImage;
        public Bitmap? convertedImage;
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

        }
        
    }
}
