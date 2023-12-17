using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace ImageViewer
{
    public partial class MainWindow : Form
    {
        bool itemChanged = false;
        bool grayScale = false;
        public Converter converter;
        public Dictionary<string, ColorProfile> profiles;
        public MainWindow()
        {
            InitializeComponent();
            imageFileDialog = new OpenFileDialog()
            {
                Title = "Choose an image",
                Filter = "|*.jpg;*.jpeg;*.png"
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
                grayScale = false;

                selectedImage.Dispose();
            }
        }

        private void sourceProfileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sourceProfileComboBox.SelectedIndex == 0)
            {
                sourceGamma.Text = string.Empty;
                sourceWhiteX.Text = string.Empty;
                sourceWhiteY.Text = string.Empty;
                sourceRedX.Text = string.Empty;
                sourceRedY.Text = string.Empty;
                sourceGreenX.Text = string.Empty;
                sourceGreenY.Text = string.Empty;
                sourceBlueX.Text = string.Empty;
                sourceBlueY.Text = string.Empty;
            }
            else

            {
                ColorProfile profile = profiles[(string)sourceProfileComboBox.SelectedItem];
                sourceGamma.Text = profile.gamma.ToString();
                sourceWhiteX.Text = profile.whiteX.ToString();
                sourceWhiteY.Text = profile.whiteY.ToString();
                sourceRedX.Text = profile.redX.ToString();
                sourceRedY.Text = profile.redY.ToString();
                sourceGreenX.Text = profile.greenX.ToString();
                sourceGreenY.Text = profile.greenY.ToString();
                sourceBlueX.Text = profile.blueX.ToString();
                sourceBlueY.Text = profile.blueY.ToString();
            }
        }

        private void resultProfileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (resultProfileComboBox.SelectedIndex == 0)
            {
                resultGamma.Text = string.Empty;
                resultWhiteX.Text = string.Empty;
                resultWhiteY.Text = string.Empty;
                resultRedX.Text = string.Empty;
                resultRedY.Text = string.Empty;
                resultGreenX.Text = string.Empty;
                resultGreenY.Text = string.Empty;
                resultBlueX.Text = string.Empty;
                resultBlueY.Text = string.Empty;
            }
            else
            {
                ColorProfile profile = profiles[(string)resultProfileComboBox.SelectedItem];
                resultGamma.Text = profile.gamma.ToString();
                resultWhiteX.Text = profile.whiteX.ToString();
                resultWhiteY.Text = profile.whiteY.ToString();
                resultRedX.Text = profile.redX.ToString();
                resultRedY.Text = profile.redY.ToString();
                resultGreenX.Text = profile.greenX.ToString();
                resultGreenY.Text = profile.greenY.ToString();
                resultBlueX.Text = profile.blueX.ToString();
                resultBlueY.Text = profile.blueY.ToString();
            }
        }

        private void sourceTextChanged(object sender, EventArgs e)
        {
            ColorProfile profile = profiles["Custom"];
            TextBox? textBox = sender as TextBox;
            if (textBox == null)
                return;
            if (!double.TryParse(textBox.Text, out double result) || result < 0)
            {
                textBox.BackColor = Color.IndianRed;
                return;
            }
            if (textBox.Tag!.ToString() != "gamma" && result > 1)
            {
                textBox.BackColor = Color.IndianRed;
                return;
            }

            profile.gamma = double.TryParse(sourceGamma.Text, out double gammaValue) ? gammaValue : 0;
            profile.whiteX = double.TryParse(sourceWhiteX.Text, out double whiteXValue) ? whiteXValue : 0;
            profile.whiteY = double.TryParse(sourceWhiteY.Text, out double whiteYValue) ? whiteYValue : 0;
            profile.redX = double.TryParse(sourceRedX.Text, out double redXValue) ? redXValue : 0;
            profile.redY = double.TryParse(sourceRedY.Text, out double redYValue) ? redYValue : 0;
            profile.greenX = double.TryParse(sourceGreenX.Text, out double greenXValue) ? greenXValue : 0;
            profile.greenY = double.TryParse(sourceGreenY.Text, out double greenYValue) ? greenYValue : 0;
            profile.blueX = double.TryParse(sourceBlueX.Text, out double blueXValue) ? blueXValue : 0;
            profile.blueY = double.TryParse(sourceBlueY.Text, out double blueYValue) ? blueYValue : 0;

            textBox.BackColor = Color.White;
            sourceProfileComboBox.SelectedIndex = 1;
            itemChanged = true;
        }

        private void convertMenuItem_Click(object sender, EventArgs e)
        {
            if (sourceProfileComboBox.SelectedIndex == 0 || resultProfileComboBox.SelectedIndex == 0
                || converter.sourceImage == null)
            {
                MessageBox.Show("Upload an image and choose valid source and result color profiles.");
                return;
            }
            ColorProfile sourceProfile = profiles[sourceProfileComboBox.Text];
            ColorProfile resultProfile = profiles[resultProfileComboBox.Text];

            converter.Convert(sourceProfile, resultProfile);
            convertedPictureBox.Image = converter.convertedImage;
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            if (converter.convertedImage == null) return;

            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Title = "Save image",
                Filter = "|*.jpg;*.jpeg;*.png",
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                converter.convertedImage.Save(saveFileDialog.FileName, GetImageFormatFromExtension(saveFileDialog.FileName));
        }
        private ImageFormat GetImageFormatFromExtension(string fileName)
        {
            string extension = Path.GetExtension(fileName)?.ToLower();

            switch (extension)
            {
                case ".png":
                    return ImageFormat.Png;
                case ".jpeg":
                case ".jpg":
                    return ImageFormat.Jpeg;
                default:
                    return ImageFormat.Png;
            }
        }

        private void grayMenuItem_Click(object sender, EventArgs e)
        {
            grayScale = !grayScale;
            if(grayScale)
            {
                converter.ConvertToGray();
                sourcePictureBox.Image = converter.grayedSourceImage;
            }

        }
    }
}
