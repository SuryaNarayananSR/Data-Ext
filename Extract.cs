using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace XML_Data_to_Excel
{
    public partial class Extract : Form
    {
        String source;
        String dest;
        public Extract()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex) { System.Diagnostics.Debug.WriteLine("Exception : " + ex); }
        }

        private void frgData_Click(object sender, EventArgs e)
        {
            try
            {
                source = srcPath.Text.Replace(@"\","/");
                dest = desPath.Text.Replace(@"\", "/");
                Forage get = new Forage(source, dest,false);
                get.obtain();
                //Closing the files
                get.destroy();

                MessageBox.Show("Success. Output Location : " + dest + ".txt");

                this.frgData.Enabled = false;
                this.exl.Enabled = false;
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Form: Text output Exception : " + ex);
                MessageBox.Show("Error : Text button Click");
            }
        }

        private void srcPath_TextChanged(object sender, EventArgs e)
        {
            srcTip.SetToolTip(srcPath, @"Sample Location :- 'C:\math.xml'");
        }

        private void desPath_TextChanged(object sender, EventArgs e)
        {
            desTip.SetToolTip(desPath, @"Sample Location(without file extension) :- 'C:\output'");
            this.frgData.Enabled = true;
            this.exl.Enabled = true;
        }

        private void desPath_Click(object sender, EventArgs e)
        {
            if (!srcPath.Text.Contains(".xml")) MessageBox.Show("Enter a valid xml source file ");
        }

        private void about_Click(object sender, EventArgs e)
        {
            About abj = new About();
            abj.Show();
        }

        private void exl_Click(object sender, EventArgs e)
        {
            try
            {
                source = srcPath.Text.Replace(@"\", "/");
                dest = desPath.Text;
                exlProgs.Visible = true;
                exlProgs.Value = 20;
                pBLab.Visible = true;
                pBLab.Text = "In Progress ...20%";
                Forage getXL = new Forage(source,dest,true);
                getXL.initProgBar(this.exlProgs,this.pBLab);
                getXL.obtain();
                //Excel save and close
                getXL.excelSave();
                exlProgs.Visible = false;
                pBLab.Visible = false;
                this.frgData.Enabled = false;
                this.exl.Enabled = false;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Form: Excel Output Exception : " + ex);
                MessageBox.Show("Error : Excel Button Click");
            }
        }
    }
}
