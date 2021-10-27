
namespace ReRoller
{
    partial class rerollerform
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
            this.buttonReroll = new System.Windows.Forms.Button();
            this.labelDone = new System.Windows.Forms.Label();
            this.SourceImagePictureBox = new System.Windows.Forms.PictureBox();
            this.ScreenToCheckPictureBox = new System.Windows.Forms.PictureBox();
            this.SourceImage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SourceImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenToCheckPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReroll
            // 
            this.buttonReroll.Location = new System.Drawing.Point(53, 238);
            this.buttonReroll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReroll.Name = "buttonReroll";
            this.buttonReroll.Size = new System.Drawing.Size(321, 29);
            this.buttonReroll.TabIndex = 0;
            this.buttonReroll.Text = "Reroll";
            this.buttonReroll.UseVisualStyleBackColor = true;
            this.buttonReroll.Click += new System.EventHandler(this.buttonReroll_Click);
            // 
            // labelDone
            // 
            this.labelDone.Location = new System.Drawing.Point(139, 279);
            this.labelDone.Name = "labelDone";
            this.labelDone.Size = new System.Drawing.Size(150, 21);
            this.labelDone.TabIndex = 1;
            // 
            // SourceImagePictureBox
            // 
            this.SourceImagePictureBox.Location = new System.Drawing.Point(37, 46);
            this.SourceImagePictureBox.Name = "SourceImagePictureBox";
            this.SourceImagePictureBox.Size = new System.Drawing.Size(153, 151);
            this.SourceImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SourceImagePictureBox.TabIndex = 2;
            this.SourceImagePictureBox.TabStop = false;
            // 
            // ScreenToCheckPictureBox
            // 
            this.ScreenToCheckPictureBox.Location = new System.Drawing.Point(253, 46);
            this.ScreenToCheckPictureBox.Name = "ScreenToCheckPictureBox";
            this.ScreenToCheckPictureBox.Size = new System.Drawing.Size(152, 151);
            this.ScreenToCheckPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ScreenToCheckPictureBox.TabIndex = 3;
            this.ScreenToCheckPictureBox.TabStop = false;
            // 
            // SourceImage
            // 
            this.SourceImage.AutoSize = true;
            this.SourceImage.Location = new System.Drawing.Point(37, 209);
            this.SourceImage.Name = "SourceImage";
            this.SourceImage.Size = new System.Drawing.Size(79, 15);
            this.SourceImage.TabIndex = 4;
            this.SourceImage.Text = "Source Image";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Screen To Check";
            // 
            // rerollerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 326);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SourceImage);
            this.Controls.Add(this.ScreenToCheckPictureBox);
            this.Controls.Add(this.SourceImagePictureBox);
            this.Controls.Add(this.labelDone);
            this.Controls.Add(this.buttonReroll);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "rerollerform";
            this.Text = "BL3 Reroller";
            ((System.ComponentModel.ISupportInitialize)(this.SourceImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenToCheckPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReroll;
        private System.Windows.Forms.Label labelDone;
        private System.Windows.Forms.PictureBox SourceImagePictureBox;
        private System.Windows.Forms.PictureBox ScreenToCheckPictureBox;
        private System.Windows.Forms.Label SourceImage;
        private System.Windows.Forms.Label label1;
    }
}

