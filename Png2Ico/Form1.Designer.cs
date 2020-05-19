namespace Png2Ico {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.btnGetFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIco = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.openImgDialog = new System.Windows.Forms.OpenFileDialog();
            this.chkRatio = new System.Windows.Forms.CheckBox();
            this.sizePercent = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sizePercent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Location";
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(12, 25);
            this.txtImage.Name = "txtImage";
            this.txtImage.ReadOnly = true;
            this.txtImage.Size = new System.Drawing.Size(305, 20);
            this.txtImage.TabIndex = 1;
            // 
            // btnGetFile
            // 
            this.btnGetFile.Location = new System.Drawing.Point(323, 25);
            this.btnGetFile.Name = "btnGetFile";
            this.btnGetFile.Size = new System.Drawing.Size(24, 20);
            this.btnGetFile.TabIndex = 2;
            this.btnGetFile.Text = "...";
            this.btnGetFile.UseVisualStyleBackColor = true;
            this.btnGetFile.Click += new System.EventHandler(this.btnGetFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ico Name";
            // 
            // txtIco
            // 
            this.txtIco.Location = new System.Drawing.Point(12, 64);
            this.txtIco.Name = "txtIco";
            this.txtIco.Size = new System.Drawing.Size(277, 20);
            this.txtIco.TabIndex = 4;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(295, 64);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(52, 20);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // openImgDialog
            // 
            this.openImgDialog.Title = "Select Image";
            // 
            // chkRatio
            // 
            this.chkRatio.AutoSize = true;
            this.chkRatio.Checked = true;
            this.chkRatio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRatio.Location = new System.Drawing.Point(12, 90);
            this.chkRatio.Name = "chkRatio";
            this.chkRatio.Size = new System.Drawing.Size(79, 17);
            this.chkRatio.TabIndex = 6;
            this.chkRatio.Text = "Keep Ratio";
            this.chkRatio.UseVisualStyleBackColor = true;
            // 
            // sizePercent
            // 
            this.sizePercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sizePercent.Location = new System.Drawing.Point(224, 90);
            this.sizePercent.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.sizePercent.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.sizePercent.Name = "sizePercent";
            this.sizePercent.Size = new System.Drawing.Size(52, 20);
            this.sizePercent.TabIndex = 7;
            this.sizePercent.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 114);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sizePercent);
            this.Controls.Add(this.chkRatio);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtIco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGetFile);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image 2 ICO";
            ((System.ComponentModel.ISupportInitialize)(this.sizePercent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Button btnGetFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIco;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.OpenFileDialog openImgDialog;
        private System.Windows.Forms.CheckBox chkRatio;
        private System.Windows.Forms.NumericUpDown sizePercent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

