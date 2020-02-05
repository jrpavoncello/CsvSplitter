namespace CsvSplitter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.fileLbl = new System.Windows.Forms.Label();
            this.cbColHead = new System.Windows.Forms.CheckBox();
            this.numPartSizeMB = new System.Windows.Forms.NumericUpDown();
            this.lblSplits = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.numPartSizeMB)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(471, 10);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.button1.Size = new System.Drawing.Size(45, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "•••";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(106, 12);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(359, 20);
            this.txtFilePath.TabIndex = 1;
            // 
            // fileLbl
            // 
            this.fileLbl.AutoSize = true;
            this.fileLbl.Location = new System.Drawing.Point(12, 15);
            this.fileLbl.Name = "fileLbl";
            this.fileLbl.Size = new System.Drawing.Size(51, 13);
            this.fileLbl.TabIndex = 2;
            this.fileLbl.Text = "File Path:";
            // 
            // cbColHead
            // 
            this.cbColHead.AutoSize = true;
            this.cbColHead.Location = new System.Drawing.Point(12, 85);
            this.cbColHead.Name = "cbColHead";
            this.cbColHead.Size = new System.Drawing.Size(126, 17);
            this.cbColHead.TabIndex = 3;
            this.cbColHead.Text = "Has Column Headers";
            this.cbColHead.UseVisualStyleBackColor = true;
            // 
            // numPartSizeMB
            // 
            this.numPartSizeMB.Location = new System.Drawing.Point(106, 49);
            this.numPartSizeMB.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numPartSizeMB.Name = "numPartSizeMB";
            this.numPartSizeMB.Size = new System.Drawing.Size(120, 20);
            this.numPartSizeMB.TabIndex = 4;
            this.numPartSizeMB.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblSplits
            // 
            this.lblSplits.AutoSize = true;
            this.lblSplits.Location = new System.Drawing.Point(12, 51);
            this.lblSplits.Name = "lblSplits";
            this.lblSplits.Size = new System.Drawing.Size(93, 13);
            this.lblSplits.TabIndex = 5;
            this.lblSplits.Text = "Size Per File (MB):";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Go";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 120);
            this.progressBar1.MarqueeAnimationSpeed = 150;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(395, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 155);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblSplits);
            this.Controls.Add(this.numPartSizeMB);
            this.Controls.Add(this.cbColHead);
            this.Controls.Add(this.fileLbl);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "CSV Splitter";
            ((System.ComponentModel.ISupportInitialize)(this.numPartSizeMB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label fileLbl;
        private System.Windows.Forms.CheckBox cbColHead;
        private System.Windows.Forms.NumericUpDown numPartSizeMB;
        private System.Windows.Forms.Label lblSplits;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

