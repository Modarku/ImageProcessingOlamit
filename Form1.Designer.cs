namespace ImageProcessingOlamit
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            imageToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            loadBackgroundforSubtractionToolStripMenuItem = new ToolStripMenuItem();
            webcamToolStripMenuItem = new ToolStripMenuItem();
            turnOnToolStripMenuItem = new ToolStripMenuItem();
            turnOffToolStripMenuItem = new ToolStripMenuItem();
            filterToolStripMenuItem = new ToolStripMenuItem();
            basicCopyToolStripMenuItem = new ToolStripMenuItem();
            grayscaleToolStripMenuItem = new ToolStripMenuItem();
            colorInversionToolStripMenuItem = new ToolStripMenuItem();
            histogramToolStripMenuItem = new ToolStripMenuItem();
            sepiaToolStripMenuItem = new ToolStripMenuItem();
            subtractionToolStripMenuItem = new ToolStripMenuItem();
            pbLoadedBox = new PictureBox();
            pbProcessedBox = new PictureBox();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            pbBackgroundBox = new PictureBox();
            openFileDialog2 = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLoadedBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProcessedBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBackgroundBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { imageToolStripMenuItem, webcamToolStripMenuItem, filterToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1801, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // imageToolStripMenuItem
            // 
            imageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem, loadBackgroundforSubtractionToolStripMenuItem });
            imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            imageToolStripMenuItem.Size = new Size(65, 24);
            imageToolStripMenuItem.Text = "Image";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(319, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(319, 26);
            loadToolStripMenuItem.Text = "Load Image";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // loadBackgroundforSubtractionToolStripMenuItem
            // 
            loadBackgroundforSubtractionToolStripMenuItem.Name = "loadBackgroundforSubtractionToolStripMenuItem";
            loadBackgroundforSubtractionToolStripMenuItem.Size = new Size(319, 26);
            loadBackgroundforSubtractionToolStripMenuItem.Text = "Load Background (for subtraction)";
            loadBackgroundforSubtractionToolStripMenuItem.Click += loadBackgroundforSubtractionToolStripMenuItem_Click;
            // 
            // webcamToolStripMenuItem
            // 
            webcamToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { turnOnToolStripMenuItem, turnOffToolStripMenuItem });
            webcamToolStripMenuItem.Name = "webcamToolStripMenuItem";
            webcamToolStripMenuItem.Size = new Size(81, 24);
            webcamToolStripMenuItem.Text = "Webcam";
            // 
            // turnOnToolStripMenuItem
            // 
            turnOnToolStripMenuItem.Name = "turnOnToolStripMenuItem";
            turnOnToolStripMenuItem.Size = new Size(144, 26);
            turnOnToolStripMenuItem.Text = "Turn on";
            turnOnToolStripMenuItem.Click += turnOnToolStripMenuItem_Click;
            // 
            // turnOffToolStripMenuItem
            // 
            turnOffToolStripMenuItem.Name = "turnOffToolStripMenuItem";
            turnOffToolStripMenuItem.Size = new Size(144, 26);
            turnOffToolStripMenuItem.Text = "Turn off";
            turnOffToolStripMenuItem.Click += turnOffToolStripMenuItem_Click;
            // 
            // filterToolStripMenuItem
            // 
            filterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { basicCopyToolStripMenuItem, grayscaleToolStripMenuItem, colorInversionToolStripMenuItem, histogramToolStripMenuItem, sepiaToolStripMenuItem, subtractionToolStripMenuItem });
            filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            filterToolStripMenuItem.Size = new Size(56, 24);
            filterToolStripMenuItem.Text = "Filter";
            // 
            // basicCopyToolStripMenuItem
            // 
            basicCopyToolStripMenuItem.Name = "basicCopyToolStripMenuItem";
            basicCopyToolStripMenuItem.Size = new Size(224, 26);
            basicCopyToolStripMenuItem.Text = "Basic Copy";
            basicCopyToolStripMenuItem.Click += basicCopyToolStripMenuItem_Click;
            // 
            // grayscaleToolStripMenuItem
            // 
            grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            grayscaleToolStripMenuItem.Size = new Size(224, 26);
            grayscaleToolStripMenuItem.Text = "Grayscale";
            grayscaleToolStripMenuItem.Click += grayscaleToolStripMenuItem_Click;
            // 
            // colorInversionToolStripMenuItem
            // 
            colorInversionToolStripMenuItem.Name = "colorInversionToolStripMenuItem";
            colorInversionToolStripMenuItem.Size = new Size(224, 26);
            colorInversionToolStripMenuItem.Text = "Color Inversion";
            colorInversionToolStripMenuItem.Click += colorInversionToolStripMenuItem_Click;
            // 
            // histogramToolStripMenuItem
            // 
            histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            histogramToolStripMenuItem.Size = new Size(224, 26);
            histogramToolStripMenuItem.Text = "Histogram";
            histogramToolStripMenuItem.Click += histogramToolStripMenuItem_Click;
            // 
            // sepiaToolStripMenuItem
            // 
            sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            sepiaToolStripMenuItem.Size = new Size(224, 26);
            sepiaToolStripMenuItem.Text = "Sepia";
            sepiaToolStripMenuItem.Click += sepiaToolStripMenuItem_Click;
            // 
            // subtractionToolStripMenuItem
            // 
            subtractionToolStripMenuItem.Name = "subtractionToolStripMenuItem";
            subtractionToolStripMenuItem.Size = new Size(224, 26);
            subtractionToolStripMenuItem.Text = "Subtraction";
            subtractionToolStripMenuItem.Click += subtractionToolStripMenuItem_Click;
            // 
            // pbLoadedBox
            // 
            pbLoadedBox.AccessibleName = "";
            pbLoadedBox.BackColor = SystemColors.ControlDark;
            pbLoadedBox.Location = new Point(12, 63);
            pbLoadedBox.Name = "pbLoadedBox";
            pbLoadedBox.Size = new Size(550, 550);
            pbLoadedBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLoadedBox.TabIndex = 1;
            pbLoadedBox.TabStop = false;
            // 
            // pbProcessedBox
            // 
            pbProcessedBox.AccessibleName = "";
            pbProcessedBox.BackColor = SystemColors.ControlDark;
            pbProcessedBox.Location = new Point(1198, 63);
            pbProcessedBox.Name = "pbProcessedBox";
            pbProcessedBox.Size = new Size(550, 550);
            pbProcessedBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProcessedBox.TabIndex = 2;
            pbProcessedBox.TabStop = false;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // pbBackgroundBox
            // 
            pbBackgroundBox.AccessibleName = "";
            pbBackgroundBox.BackColor = SystemColors.ControlDark;
            pbBackgroundBox.Location = new Point(607, 63);
            pbBackgroundBox.Name = "pbBackgroundBox";
            pbBackgroundBox.Size = new Size(550, 550);
            pbBackgroundBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBackgroundBox.TabIndex = 3;
            pbBackgroundBox.TabStop = false;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            openFileDialog2.FileOk += openFileDialog2_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1801, 642);
            Controls.Add(pbBackgroundBox);
            Controls.Add(pbProcessedBox);
            Controls.Add(pbLoadedBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLoadedBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProcessedBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBackgroundBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem imageToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem webcamToolStripMenuItem;
        private ToolStripMenuItem turnOnToolStripMenuItem;
        private ToolStripMenuItem turnOffToolStripMenuItem;
        private ToolStripMenuItem filterToolStripMenuItem;
        private ToolStripMenuItem basicCopyToolStripMenuItem;
        private ToolStripMenuItem grayscaleToolStripMenuItem;
        private ToolStripMenuItem colorInversionToolStripMenuItem;
        private ToolStripMenuItem histogramToolStripMenuItem;
        private ToolStripMenuItem sepiaToolStripMenuItem;
        private PictureBox pbLoadedBox;
        private PictureBox pbProcessedBox;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private PictureBox pbBackgroundBox;
        private OpenFileDialog openFileDialog2;
        private ToolStripMenuItem loadBackgroundforSubtractionToolStripMenuItem;
        private ToolStripMenuItem subtractionToolStripMenuItem;
    }
}
