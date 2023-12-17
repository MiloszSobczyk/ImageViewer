using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ImageViewer
{
    public partial class MainWindow : Form
    {
        public Converter converter;
        public Dictionary<string, ColorProfile> profiles;
        public MainWindow()
        {
            InitializeComponent();
            imageFileDialog = new OpenFileDialog()
            {
                Title = "Choose an image",
                Filter = "|*.jpg;*.jpeg;*.png;*.bmp"
            };

            converter = new Converter();
            profiles = ColorProfile.GenerateProfiles();

            List<string> elements = profiles.Keys.ToList();
            elements.Insert(0, "");
            sourceProfileComboBox.DataSource = elements;

            elements = profiles.Keys.ToList();
            elements.Insert(0, "");
            resultProfileComboBox.DataSource = elements;

            converter.Convert();
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

                converter.UploadImage(resizedImage);
                sourcePictureBox.Image = resizedImage;


                selectedImage.Dispose();
            }
        }

        private void sourceProfileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
