
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
            this.SuspendLayout();
            // 
            // buttonReroll
            // 
            this.buttonReroll.Location = new System.Drawing.Point(61, 317);
            this.buttonReroll.Name = "buttonReroll";
            this.buttonReroll.Size = new System.Drawing.Size(367, 39);
            this.buttonReroll.TabIndex = 0;
            this.buttonReroll.Text = "Reroll";
            this.buttonReroll.UseVisualStyleBackColor = true;
            this.buttonReroll.Click += new System.EventHandler(this.buttonReroll_Click);
            // 
            // labelDone
            // 
            this.labelDone.Location = new System.Drawing.Point(159, 372);
            this.labelDone.Name = "labelDone";
            this.labelDone.Size = new System.Drawing.Size(171, 28);
            this.labelDone.TabIndex = 1;
            // 
            // rerollerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 434);
            this.Controls.Add(this.labelDone);
            this.Controls.Add(this.buttonReroll);
            this.Name = "rerollerform";
            this.Text = "BL3 Reroller";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReroll;
        private System.Windows.Forms.Label labelDone;
    }
}

