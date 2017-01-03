using System;
using System.Drawing;
using System.Windows.Forms;

namespace XML_Data_to_Excel
{
    public partial class About : Form
    {
        public About()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex) { System.Diagnostics.Debug.WriteLine("Exception : " + ex); }
        }

    }
}
