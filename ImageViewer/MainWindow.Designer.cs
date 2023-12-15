namespace ImageViewer
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            openImageMenuItem = new ToolStripMenuItem();
            convertMenuItem = new ToolStripMenuItem();
            saveMenuItem = new ToolStripMenuItem();
            grayMenuItem = new ToolStripMenuItem();
            sourcePictureBox = new PictureBox();
            resultPictureBox = new PictureBox();
            imageFileDialog = new OpenFileDialog();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sourcePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultPictureBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = SystemColors.Desktop;
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { openImageMenuItem, convertMenuItem, saveMenuItem, grayMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1182, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // openImageMenuItem
            // 
            openImageMenuItem.ForeColor = SystemColors.Window;
            openImageMenuItem.Name = "openImageMenuItem";
            openImageMenuItem.Size = new Size(105, 24);
            openImageMenuItem.Text = "Open image";
            openImageMenuItem.Click += openImageMenuItem_Click;
            // 
            // convertMenuItem
            // 
            convertMenuItem.ForeColor = SystemColors.Window;
            convertMenuItem.Name = "convertMenuItem";
            convertMenuItem.Size = new Size(74, 24);
            convertMenuItem.Text = "Convert";
            // 
            // saveMenuItem
            // 
            saveMenuItem.ForeColor = SystemColors.Window;
            saveMenuItem.Name = "saveMenuItem";
            saveMenuItem.Size = new Size(54, 24);
            saveMenuItem.Text = "Save";
            // 
            // grayMenuItem
            // 
            grayMenuItem.BackColor = SystemColors.Desktop;
            grayMenuItem.ForeColor = SystemColors.Window;
            grayMenuItem.Name = "grayMenuItem";
            grayMenuItem.Size = new Size(53, 24);
            grayMenuItem.Text = "Gray";
            grayMenuItem.Click += grayScaleToolStripMenuItem_Click;
            // 
            // sourcePictureBox
            // 
            sourcePictureBox.Location = new Point(12, 164);
            sourcePictureBox.Name = "sourcePictureBox";
            sourcePictureBox.Size = new Size(576, 477);
            sourcePictureBox.TabIndex = 1;
            sourcePictureBox.TabStop = false;
            // 
            // resultPictureBox
            // 
            resultPictureBox.Location = new Point(600, 164);
            resultPictureBox.Name = "resultPictureBox";
            resultPictureBox.Size = new Size(576, 477);
            resultPictureBox.TabIndex = 2;
            resultPictureBox.TabStop = false;
            // 
            // imageFileDialog
            // 
            imageFileDialog.FileName = "sourceImage";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1182, 653);
            Controls.Add(resultPictureBox);
            Controls.Add(sourcePictureBox);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "MainWindow";
            Text = "Image Viewer";
            Load += MainWindow_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sourcePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem openImageMenuItem;
        private ToolStripMenuItem convertMenuItem;
        private ToolStripMenuItem saveMenuItem;
        private ToolStripMenuItem grayMenuItem;
        private PictureBox sourcePictureBox;
        private PictureBox resultPictureBox;
        private OpenFileDialog imageFileDialog;
    }
}
