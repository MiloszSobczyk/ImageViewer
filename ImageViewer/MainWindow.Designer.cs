﻿namespace ImageViewer
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
            convertedPictureBox = new PictureBox();
            imageFileDialog = new OpenFileDialog();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            comboBox2 = new ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label1 = new Label();
            tableLayoutPanel10 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            label9 = new Label();
            comboBox3 = new ComboBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            textBox9 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            textBox10 = new TextBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            textBox15 = new TextBox();
            textBox16 = new TextBox();
            label17 = new Label();
            comboBox1 = new ComboBox();
            tableLayoutPanel11 = new TableLayoutPanel();
            tableLayoutPanel12 = new TableLayoutPanel();
            label18 = new Label();
            label19 = new Label();
            textBox17 = new TextBox();
            textBox18 = new TextBox();
            tableLayoutPanel13 = new TableLayoutPanel();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            textBox19 = new TextBox();
            textBox20 = new TextBox();
            textBox21 = new TextBox();
            textBox22 = new TextBox();
            textBox23 = new TextBox();
            textBox24 = new TextBox();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sourcePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)convertedPictureBox).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
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
            // 
            // sourcePictureBox
            // 
            sourcePictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sourcePictureBox.Location = new Point(3, 247);
            sourcePictureBox.Name = "sourcePictureBox";
            sourcePictureBox.Size = new Size(573, 360);
            sourcePictureBox.TabIndex = 1;
            sourcePictureBox.TabStop = false;
            // 
            // convertedPictureBox
            // 
            convertedPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            convertedPictureBox.Location = new Point(582, 247);
            convertedPictureBox.Name = "convertedPictureBox";
            convertedPictureBox.Size = new Size(573, 360);
            convertedPictureBox.TabIndex = 2;
            convertedPictureBox.TabStop = false;
            // 
            // imageFileDialog
            // 
            imageFileDialog.FileName = "sourceImage";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(sourcePictureBox, 0, 1);
            tableLayoutPanel1.Controls.Add(convertedPictureBox, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel10, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 31);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1158, 610);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.AutoScroll = true;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(comboBox2, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(579, 244);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(5, 53);
            comboBox2.Margin = new Padding(5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(286, 28);
            comboBox2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel3.Location = new Point(0, 96);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(579, 148);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel4.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Controls.Add(label3, 0, 1);
            tableLayoutPanel4.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(289, 148);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(130, 97);
            textBox2.Margin = new Padding(5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(5, 5);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Size = new Size(86, 64);
            label2.TabIndex = 0;
            label2.Text = "Gamma:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(5, 79);
            label3.Margin = new Padding(5);
            label3.Name = "label3";
            label3.Size = new Size(86, 64);
            label3.TabIndex = 1;
            label3.Text = "White:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(130, 23);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.Controls.Add(label4, 1, 0);
            tableLayoutPanel5.Controls.Add(label5, 2, 0);
            tableLayoutPanel5.Controls.Add(label6, 0, 1);
            tableLayoutPanel5.Controls.Add(label7, 0, 2);
            tableLayoutPanel5.Controls.Add(label8, 0, 3);
            tableLayoutPanel5.Controls.Add(textBox3, 1, 1);
            tableLayoutPanel5.Controls.Add(textBox4, 2, 1);
            tableLayoutPanel5.Controls.Add(textBox5, 1, 2);
            tableLayoutPanel5.Controls.Add(textBox6, 2, 2);
            tableLayoutPanel5.Controls.Add(textBox7, 1, 3);
            tableLayoutPanel5.Controls.Add(textBox8, 2, 3);
            tableLayoutPanel5.Location = new Point(289, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 4;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tableLayoutPanel5.Size = new Size(290, 148);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(97, 1);
            label4.Margin = new Padding(1);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 0;
            label4.Text = "x";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(193, 1);
            label5.Margin = new Padding(1);
            label5.Name = "label5";
            label5.Size = new Size(96, 21);
            label5.TabIndex = 1;
            label5.Text = "y";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(1, 24);
            label6.Margin = new Padding(1);
            label6.Name = "label6";
            label6.Size = new Size(94, 39);
            label6.TabIndex = 2;
            label6.Text = "Red:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(1, 65);
            label7.Margin = new Padding(1);
            label7.Name = "label7";
            label7.Size = new Size(94, 39);
            label7.TabIndex = 3;
            label7.Text = "Green:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(1, 106);
            label8.Margin = new Padding(1);
            label8.Name = "label8";
            label8.Size = new Size(94, 41);
            label8.TabIndex = 4;
            label8.Text = "Blue:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(101, 30);
            textBox3.Margin = new Padding(5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(86, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Location = new Point(198, 30);
            textBox4.Margin = new Padding(5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(86, 27);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.Location = new Point(101, 71);
            textBox5.Margin = new Padding(5);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(86, 27);
            textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.Location = new Point(198, 71);
            textBox6.Margin = new Padding(5);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(86, 27);
            textBox6.TabIndex = 8;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.None;
            textBox7.Location = new Point(101, 113);
            textBox7.Margin = new Padding(5);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(86, 27);
            textBox7.TabIndex = 9;
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.None;
            textBox8.Location = new Point(198, 113);
            textBox8.Margin = new Padding(5);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(86, 27);
            textBox8.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 5);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(569, 38);
            label1.TabIndex = 0;
            label1.Text = "Source color profile";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Controls.Add(label17, 0, 0);
            tableLayoutPanel10.Controls.Add(comboBox1, 0, 1);
            tableLayoutPanel10.Controls.Add(tableLayoutPanel11, 0, 2);
            tableLayoutPanel10.Location = new Point(579, 0);
            tableLayoutPanel10.Margin = new Padding(0);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 3;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel10.Size = new Size(579, 244);
            tableLayoutPanel10.TabIndex = 7;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel6.AutoScroll = true;
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(label9, 0, 0);
            tableLayoutPanel6.Controls.Add(comboBox3, 0, 1);
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.Size = new Size(200, 100);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(5, 5);
            label9.Margin = new Padding(5);
            label9.Name = "label9";
            label9.Size = new Size(190, 62);
            label9.TabIndex = 0;
            label9.Text = "Source color profile";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(5, 77);
            comboBox3.Margin = new Padding(5);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(190, 28);
            comboBox3.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 0, 0);
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.Size = new Size(200, 100);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.294117F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.70588F));
            tableLayoutPanel8.Controls.Add(textBox9, 1, 1);
            tableLayoutPanel8.Controls.Add(label10, 0, 0);
            tableLayoutPanel8.Controls.Add(label11, 0, 1);
            tableLayoutPanel8.Controls.Add(textBox10, 1, 0);
            tableLayoutPanel8.Location = new Point(0, 0);
            tableLayoutPanel8.Margin = new Padding(0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(100, 142);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // textBox9
            // 
            textBox9.Anchor = AnchorStyles.None;
            textBox9.Location = new Point(40, 93);
            textBox9.Margin = new Padding(5);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(55, 27);
            textBox9.TabIndex = 3;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(5, 5);
            label10.Margin = new Padding(5);
            label10.Name = "label10";
            label10.Size = new Size(25, 61);
            label10.TabIndex = 0;
            label10.Text = "Gamma:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(5, 76);
            label11.Margin = new Padding(5);
            label11.Name = "label11";
            label11.Size = new Size(25, 61);
            label11.TabIndex = 1;
            label11.Text = "White:";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox10
            // 
            textBox10.Anchor = AnchorStyles.None;
            textBox10.Location = new Point(40, 22);
            textBox10.Margin = new Padding(5);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(55, 27);
            textBox10.TabIndex = 2;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel9.ColumnCount = 3;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel9.Controls.Add(label12, 1, 0);
            tableLayoutPanel9.Controls.Add(label13, 2, 0);
            tableLayoutPanel9.Controls.Add(label14, 0, 1);
            tableLayoutPanel9.Controls.Add(label15, 0, 2);
            tableLayoutPanel9.Controls.Add(label16, 0, 3);
            tableLayoutPanel9.Controls.Add(textBox11, 1, 1);
            tableLayoutPanel9.Controls.Add(textBox12, 2, 1);
            tableLayoutPanel9.Controls.Add(textBox13, 1, 2);
            tableLayoutPanel9.Controls.Add(textBox14, 2, 2);
            tableLayoutPanel9.Controls.Add(textBox15, 1, 3);
            tableLayoutPanel9.Controls.Add(textBox16, 2, 3);
            tableLayoutPanel9.Location = new Point(100, 0);
            tableLayoutPanel9.Margin = new Padding(0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 4;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tableLayoutPanel9.Size = new Size(100, 142);
            tableLayoutPanel9.TabIndex = 1;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(34, 1);
            label12.Margin = new Padding(1);
            label12.Name = "label12";
            label12.Size = new Size(31, 20);
            label12.TabIndex = 0;
            label12.Text = "x";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(67, 1);
            label13.Margin = new Padding(1);
            label13.Name = "label13";
            label13.Size = new Size(32, 20);
            label13.TabIndex = 1;
            label13.Text = "y";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Location = new Point(1, 23);
            label14.Margin = new Padding(1);
            label14.Name = "label14";
            label14.Size = new Size(31, 37);
            label14.TabIndex = 2;
            label14.Text = "Red:";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Location = new Point(1, 62);
            label15.Margin = new Padding(1);
            label15.Name = "label15";
            label15.Size = new Size(31, 37);
            label15.TabIndex = 3;
            label15.Text = "Green:";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Location = new Point(1, 101);
            label16.Margin = new Padding(1);
            label16.Name = "label16";
            label16.Size = new Size(31, 40);
            label16.TabIndex = 4;
            label16.Text = "Blue:";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox11
            // 
            textBox11.Anchor = AnchorStyles.None;
            textBox11.Location = new Point(38, 28);
            textBox11.Margin = new Padding(5);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(23, 27);
            textBox11.TabIndex = 5;
            // 
            // textBox12
            // 
            textBox12.Anchor = AnchorStyles.None;
            textBox12.Location = new Point(71, 28);
            textBox12.Margin = new Padding(5);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(24, 27);
            textBox12.TabIndex = 6;
            // 
            // textBox13
            // 
            textBox13.Anchor = AnchorStyles.None;
            textBox13.Location = new Point(38, 67);
            textBox13.Margin = new Padding(5);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(23, 27);
            textBox13.TabIndex = 7;
            // 
            // textBox14
            // 
            textBox14.Anchor = AnchorStyles.None;
            textBox14.Location = new Point(71, 67);
            textBox14.Margin = new Padding(5);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(24, 27);
            textBox14.TabIndex = 8;
            // 
            // textBox15
            // 
            textBox15.Anchor = AnchorStyles.None;
            textBox15.Location = new Point(38, 107);
            textBox15.Margin = new Padding(5);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(23, 27);
            textBox15.TabIndex = 9;
            // 
            // textBox16
            // 
            textBox16.Anchor = AnchorStyles.None;
            textBox16.Location = new Point(71, 107);
            textBox16.Margin = new Padding(5);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(24, 27);
            textBox16.TabIndex = 10;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(5, 5);
            label17.Margin = new Padding(5);
            label17.Name = "label17";
            label17.Size = new Size(569, 38);
            label17.TabIndex = 1;
            label17.Text = "Result color profile";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(5, 53);
            comboBox1.Margin = new Padding(5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(286, 28);
            comboBox1.TabIndex = 2;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(tableLayoutPanel12, 0, 0);
            tableLayoutPanel11.Controls.Add(tableLayoutPanel13, 1, 0);
            tableLayoutPanel11.Location = new Point(0, 96);
            tableLayoutPanel11.Margin = new Padding(0);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel11.Size = new Size(579, 148);
            tableLayoutPanel11.TabIndex = 3;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel12.ColumnCount = 2;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel12.Controls.Add(label19, 0, 1);
            tableLayoutPanel12.Controls.Add(label18, 0, 0);
            tableLayoutPanel12.Controls.Add(textBox17, 1, 0);
            tableLayoutPanel12.Controls.Add(textBox18, 1, 1);
            tableLayoutPanel12.Location = new Point(0, 0);
            tableLayoutPanel12.Margin = new Padding(0);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 2;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Size = new Size(289, 148);
            tableLayoutPanel12.TabIndex = 0;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(5, 5);
            label18.Margin = new Padding(5);
            label18.Name = "label18";
            label18.Size = new Size(86, 64);
            label18.TabIndex = 1;
            label18.Text = "Gamma:";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(5, 79);
            label19.Margin = new Padding(5);
            label19.Name = "label19";
            label19.Size = new Size(86, 64);
            label19.TabIndex = 2;
            label19.Text = "White:";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox17
            // 
            textBox17.Anchor = AnchorStyles.None;
            textBox17.Location = new Point(130, 23);
            textBox17.Margin = new Padding(5);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(125, 27);
            textBox17.TabIndex = 3;
            // 
            // textBox18
            // 
            textBox18.Anchor = AnchorStyles.None;
            textBox18.Location = new Point(130, 97);
            textBox18.Margin = new Padding(5);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(125, 27);
            textBox18.TabIndex = 4;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel13.ColumnCount = 3;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel13.Controls.Add(textBox24, 0, 3);
            tableLayoutPanel13.Controls.Add(label22, 0, 3);
            tableLayoutPanel13.Controls.Add(label20, 0, 1);
            tableLayoutPanel13.Controls.Add(label21, 0, 2);
            tableLayoutPanel13.Controls.Add(label23, 1, 0);
            tableLayoutPanel13.Controls.Add(label24, 2, 0);
            tableLayoutPanel13.Controls.Add(textBox19, 1, 1);
            tableLayoutPanel13.Controls.Add(textBox20, 2, 1);
            tableLayoutPanel13.Controls.Add(textBox21, 1, 2);
            tableLayoutPanel13.Controls.Add(textBox22, 2, 2);
            tableLayoutPanel13.Controls.Add(textBox23, 1, 3);
            tableLayoutPanel13.Location = new Point(289, 0);
            tableLayoutPanel13.Margin = new Padding(0);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 4;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tableLayoutPanel13.Size = new Size(290, 148);
            tableLayoutPanel13.TabIndex = 1;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.Location = new Point(1, 24);
            label20.Margin = new Padding(1);
            label20.Name = "label20";
            label20.Size = new Size(94, 39);
            label20.TabIndex = 3;
            label20.Text = "Red:";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label21.AutoSize = true;
            label21.Location = new Point(1, 65);
            label21.Margin = new Padding(1);
            label21.Name = "label21";
            label21.Size = new Size(94, 39);
            label21.TabIndex = 4;
            label21.Text = "Green:";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label22.AutoSize = true;
            label22.Location = new Point(1, 106);
            label22.Margin = new Padding(1);
            label22.Name = "label22";
            label22.Size = new Size(94, 41);
            label22.TabIndex = 5;
            label22.Text = "Blue:";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label23.AutoSize = true;
            label23.Location = new Point(97, 1);
            label23.Margin = new Padding(1);
            label23.Name = "label23";
            label23.Size = new Size(94, 21);
            label23.TabIndex = 6;
            label23.Text = "x";
            label23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label24.AutoSize = true;
            label24.Location = new Point(193, 1);
            label24.Margin = new Padding(1);
            label24.Name = "label24";
            label24.Size = new Size(96, 21);
            label24.TabIndex = 7;
            label24.Text = "y";
            label24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox19
            // 
            textBox19.Anchor = AnchorStyles.None;
            textBox19.Location = new Point(101, 30);
            textBox19.Margin = new Padding(5);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(86, 27);
            textBox19.TabIndex = 8;
            // 
            // textBox20
            // 
            textBox20.Anchor = AnchorStyles.None;
            textBox20.Location = new Point(198, 30);
            textBox20.Margin = new Padding(5);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(86, 27);
            textBox20.TabIndex = 9;
            // 
            // textBox21
            // 
            textBox21.Anchor = AnchorStyles.None;
            textBox21.Location = new Point(101, 71);
            textBox21.Margin = new Padding(5);
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(86, 27);
            textBox21.TabIndex = 10;
            // 
            // textBox22
            // 
            textBox22.Anchor = AnchorStyles.None;
            textBox22.Location = new Point(198, 71);
            textBox22.Margin = new Padding(5);
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(86, 27);
            textBox22.TabIndex = 11;
            // 
            // textBox23
            // 
            textBox23.Anchor = AnchorStyles.None;
            textBox23.Location = new Point(198, 113);
            textBox23.Margin = new Padding(5);
            textBox23.Name = "textBox23";
            textBox23.Size = new Size(86, 27);
            textBox23.TabIndex = 12;
            // 
            // textBox24
            // 
            textBox24.Anchor = AnchorStyles.None;
            textBox24.Location = new Point(101, 113);
            textBox24.Margin = new Padding(5);
            textBox24.Name = "textBox24";
            textBox24.Size = new Size(86, 27);
            textBox24.TabIndex = 13;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1182, 653);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "MainWindow";
            Text = "Image Viewer";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sourcePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)convertedPictureBox).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel13.PerformLayout();
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
        private PictureBox convertedPictureBox;
        private OpenFileDialog imageFileDialog;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private ComboBox comboBox2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label9;
        private ComboBox comboBox3;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private TextBox textBox9;
        private Label label10;
        private Label label11;
        private TextBox textBox10;
        private TableLayoutPanel tableLayoutPanel9;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox15;
        private TextBox textBox16;
        private TableLayoutPanel tableLayoutPanel10;
        private ComboBox comboBox1;
        private Label label17;
        private TableLayoutPanel tableLayoutPanel11;
        private TableLayoutPanel tableLayoutPanel12;
        private Label label19;
        private Label label18;
        private TextBox textBox17;
        private TextBox textBox18;
        private TableLayoutPanel tableLayoutPanel13;
        private TextBox textBox24;
        private Label label22;
        private Label label20;
        private Label label21;
        private Label label23;
        private Label label24;
        private TextBox textBox19;
        private TextBox textBox20;
        private TextBox textBox21;
        private TextBox textBox22;
        private TextBox textBox23;
    }
}
