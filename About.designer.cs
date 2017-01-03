namespace XML_Data_to_Excel
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.lakshya = new System.Windows.Forms.PictureBox();
            this.aboutInfo = new System.Windows.Forms.TextBox();
            this.SG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lakshya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SG)).BeginInit();
            this.SuspendLayout();
            // 
            // lakshya
            // 
            this.lakshya.Image = ((System.Drawing.Image)(resources.GetObject("lakshya.Image")));
            this.lakshya.Location = new System.Drawing.Point(12, 203);
            this.lakshya.Name = "lakshya";
            this.lakshya.Size = new System.Drawing.Size(125, 83);
            this.lakshya.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lakshya.TabIndex = 0;
            this.lakshya.TabStop = false;
            // 
            // aboutInfo
            // 
            this.aboutInfo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.aboutInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.aboutInfo.Location = new System.Drawing.Point(15, 12);
            this.aboutInfo.Multiline = true;
            this.aboutInfo.Name = "aboutInfo";
            this.aboutInfo.ReadOnly = true;
            this.aboutInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.aboutInfo.Size = new System.Drawing.Size(482, 172);
            this.aboutInfo.TabIndex = 2;
            this.aboutInfo.TabStop = false;
            this.aboutInfo.Text = resources.GetString("aboutInfo.Text");
            // 
            // SG
            // 
            this.SG.Image = ((System.Drawing.Image)(resources.GetObject("SG.Image")));
            this.SG.Location = new System.Drawing.Point(302, 203);
            this.SG.Name = "SG";
            this.SG.Size = new System.Drawing.Size(190, 83);
            this.SG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SG.TabIndex = 1;
            this.SG.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 298);
            this.Controls.Add(this.aboutInfo);
            this.Controls.Add(this.SG);
            this.Controls.Add(this.lakshya);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.lakshya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.PictureBox lakshya;
        private System.Windows.Forms.TextBox aboutInfo;
        private System.Windows.Forms.PictureBox SG;
    }
}