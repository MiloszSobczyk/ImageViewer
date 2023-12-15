using System.Windows.Forms;

namespace ImageViewer
{
    public partial class MainWindow : Form
    {
        public Converter Converter { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            imageFileDialog = new OpenFileDialog()
            {
                Title = "Choose an image",
                Filter = "|*.jpg;*.jpeg;*.png;*.bmp"
            };

            Converter = new Converter();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openImageMenuItem_Click(object sender, EventArgs e)
        {
            if (imageFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap selectedImage = new Bitmap(imageFileDialog.FileName);
                Bitmap resizedImage = new Bitmap(sourcePictureBox.Width, sourcePictureBox.Height);

                using (Graphics g = Graphics.FromImage(resizedImage))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.DrawImage(selectedImage, 0, 0, sourcePictureBox.Width, sourcePictureBox.Height);
                }

                Converter.UploadImage(resizedImage);
                sourcePictureBox.Image = resizedImage;

                selectedImage.Dispose();
            }
        }
    }
}
