using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
    }
}
