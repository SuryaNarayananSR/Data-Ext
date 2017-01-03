namespace XML_Data_to_Excel
{
    partial class Extract
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Extract));
            this.srcPath = new System.Windows.Forms.TextBox();
            this.srcLab = new System.Windows.Forms.Label();
            this.desLab = new System.Windows.Forms.Label();
            this.desPath = new System.Windows.Forms.TextBox();
            this.frgData = new System.Windows.Forms.Button();
            this.srcTip = new System.Windows.Forms.ToolTip(this.components);
            this.desTip = new System.Windows.Forms.ToolTip(this.components);
            this.about = new System.Windows.Forms.Label();
            this.exl = new System.Windows.Forms.Button();
            this.exlProgs = new System.Windows.Forms.ProgressBar();
            this.pBLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // srcPath
            // 
            this.srcPath.Location = new System.Drawing.Point(200, 74);
            this.srcPath.Name = "srcPath";
            this.srcPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.srcPath.Size = new System.Drawing.Size(298, 20);
            this.srcPath.TabIndex = 0;
            this.srcTip.SetToolTip(this.srcPath, "Enter the Source File Path.\r\n");
            this.srcPath.TextChanged += new System.EventHandler(this.srcPath_TextChanged);
            // 
            // srcLab
            // 
            this.srcLab.AutoSize = true;
            this.srcLab.Location = new System.Drawing.Point(49, 74);
            this.srcLab.Name = "srcLab";
            this.srcLab.Size = new System.Drawing.Size(75, 13);
            this.srcLab.TabIndex = 1;
            this.srcLab.Text = "Source Path :-";
            this.srcTip.SetToolTip(this.srcLab, "Sample : C:\\math.xml");
            // 
            // desLab
            // 
            this.desLab.AutoSize = true;
            this.desLab.Location = new System.Drawing.Point(49, 164);
            this.desLab.Name = "desLab";
            this.desLab.Size = new System.Drawing.Size(94, 13);
            this.desLab.TabIndex = 2;
            this.desLab.Text = "Destination Path :-";
            this.desTip.SetToolTip(this.desLab, "Sample : C:\\output");
            // 
            // desPath
            // 
            this.desPath.Location = new System.Drawing.Point(200, 157);
            this.desPath.Name = "desPath";
            this.desPath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.desPath.Size = new System.Drawing.Size(298, 20);
            this.desPath.TabIndex = 3;
            this.desTip.SetToolTip(this.desPath, "Enter the Destination File path");
            this.desPath.Click += new System.EventHandler(this.desPath_Click);
            this.desPath.TextChanged += new System.EventHandler(this.desPath_TextChanged);
            // 
            // frgData
            // 
            this.frgData.Enabled = false;
            this.frgData.Location = new System.Drawing.Point(110, 256);
            this.frgData.Name = "frgData";
            this.frgData.Size = new System.Drawing.Size(76, 34);
            this.frgData.TabIndex = 4;
            this.frgData.Text = "Obtain in Text";
            this.frgData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.frgData.UseVisualStyleBackColor = true;
            this.frgData.Click += new System.EventHandler(this.frgData_Click);
            // 
            // srcTip
            // 
            this.srcTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.srcTip.ToolTipTitle = "Source Path - Math.xml file";
            // 
            // desTip
            // 
            this.desTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.desTip.ToolTipTitle = "Destination Path and filename without extension";
            // 
            // about
            // 
            this.about.AutoSize = true;
            this.about.Cursor = System.Windows.Forms.Cursors.Help;
            this.about.Location = new System.Drawing.Point(12, 318);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(35, 13);
            this.about.TabIndex = 5;
            this.about.Text = "About";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // exl
            // 
            this.exl.Enabled = false;
            this.exl.Location = new System.Drawing.Point(355, 256);
            this.exl.Name = "exl";
            this.exl.Size = new System.Drawing.Size(79, 34);
            this.exl.TabIndex = 6;
            this.exl.Text = "Obtain in Excel";
            this.exl.UseVisualStyleBackColor = true;
            this.exl.Click += new System.EventHandler(this.exl_Click);
            // 
            // exlProgs
            // 
            this.exlProgs.Location = new System.Drawing.Point(355, 309);
            this.exlProgs.Name = "exlProgs";
            this.exlProgs.Size = new System.Drawing.Size(79, 23);
            this.exlProgs.TabIndex = 7;
            this.exlProgs.Visible = false;
            // 
            // pBLab
            // 
            this.pBLab.AutoSize = true;
            this.pBLab.Location = new System.Drawing.Point(352, 293);
            this.pBLab.Name = "pBLab";
            this.pBLab.Size = new System.Drawing.Size(0, 13);
            this.pBLab.TabIndex = 8;
            this.pBLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pBLab.Visible = false;
            // 
            // Extract
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 340);
            this.Controls.Add(this.pBLab);
            this.Controls.Add(this.exlProgs);
            this.Controls.Add(this.exl);
            this.Controls.Add(this.about);
            this.Controls.Add(this.frgData);
            this.Controls.Add(this.desPath);
            this.Controls.Add(this.desLab);
            this.Controls.Add(this.srcLab);
            this.Controls.Add(this.srcPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Extract";
            this.Text = "Math Data-Extracter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox srcPath;
        private System.Windows.Forms.Label srcLab;
        private System.Windows.Forms.Label desLab;
        private System.Windows.Forms.TextBox desPath;
        private System.Windows.Forms.Button frgData;
        private System.Windows.Forms.ToolTip srcTip;
        private System.Windows.Forms.ToolTip desTip;
        private System.Windows.Forms.Label about;
        private System.Windows.Forms.Button exl;
        private System.Windows.Forms.ProgressBar exlProgs;
        private System.Windows.Forms.Label pBLab;
    }
}