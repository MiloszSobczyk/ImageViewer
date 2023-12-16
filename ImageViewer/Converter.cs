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
        
    }
}
