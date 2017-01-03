using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace XML_Data_to_Excel
{
    class Forage
    {
        string line;                 //Reader Line
        string buff;                 //Writer Buffer 
        string desPath;              //Destination file path
        string srcPath;              //Source file path
        string srcNew;               //Temperoary file to store source data without blank spaces

        bool jumpFlag = false;       //Jump Flag : 'false' writes in text file, 'true' writes in Excel file

        StreamReader sr;
        StreamWriter sw,swNS;

        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlWS;
        int r, c = 2;                //Row and Coloumn index for excel. Default coloum index as 2

        System.Windows.Forms.ProgressBar exlProgs; // Progress bar to indcate the Progress of Excel file creation
        System.Windows.Forms.Label pBLab;

        internal Forage()
        { }

        internal Forage(String s, String d,bool wrJmp)
        {
            try
            {
                srcPath = s;
                //setting Write Jump Flag
                jumpFlag = wrJmp;

                //setting destination according to jumper
                if (!jumpFlag) desPath = d + ".txt";
                else desPath = d + ".xlsx";

                //temp file to store intermidiate data - This file contains the Source file data without blank spaces
                srcNew = Path.GetTempPath() + "test1.txt";

                //Destroying the space in source file
                sr = new StreamReader(srcPath);
                spaceBust();
                sr.Close();

                //obtaining the file to be foraged
                sr = new StreamReader(srcNew);

                //Creating Writer obj according to jumpFlag : false - Text Writer , true - Excel App
                if (!jumpFlag)
                {
                    //Creating new empty text file
                    sw = File.CreateText(desPath);
                    sw.Write("");
                    sw.Close();

                    //open the text file in append mode
                    sw = File.AppendText(desPath);
                }
                else
                {
                    //creating Excel sheel
                    xlApp = new Excel.Application();

                    //Excel instalation check
                    if (xlApp == null)
                        System.Windows.Forms.MessageBox.Show("Excel not installed properly");

                    //Creating workbook and worksheet
                    xlWB = xlApp.Workbooks.Add();
                    xlWS = (Excel.Worksheet)xlWB.Worksheets[1];
                    if (xlWS == null)
                        System.Windows.Forms.MessageBox.Show("Excel not installed properly");
                }
            }
            catch (Exception ex) 
            { 
                System.Diagnostics.Debug.WriteLine("Constructor Exception : " + ex);
                if (ex.ToString().Contains("Excel")) MessageBox.Show("Exception" + ex +" ::: Unable to Construct Excel File");
                else MessageBox.Show("Exception" + ex +" ::: Unable to Open Source files or Text Files "); ;
            }
        }


        internal void destroy()
        {
            try
            {
                //Closing the Files
                sr.Close();
                sw.Close();
            }
            catch(Exception ex){
                System.Diagnostics.Debug.WriteLine("Destroyer Exception : " + ex);
                MessageBox.Show("Exception" + ex +" ::: Unable to Close text Files");
            }
        }


        void spaceBust()
        {
            try
            {
                swNS = new StreamWriter(srcNew);
                while ((line = sr.ReadLine()) != null)
                {
                    //Replacing blank spaces with no value - deleting all blank areas
                    string tmp = line.Replace("\t", "").Replace(" ", "");
                    swNS.WriteLine(tmp);
                }
                //File Close
                swNS.Close();
                return;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("SpaceBuster Exception : " + ex);
            }
        }


        internal void obtain()
        {
            try
            {
                int cnt;
                int plCnt = 0;
                if (jumpFlag) { exlProgs.Value = 40; pBLab.Text = "In Progress ...40%"; }

                for (cnt = 1; (line = sr.ReadLine()) != null;cnt++ )
                {
                    //Row index value calculation for the excel docx
                    r = cnt + plCnt;
                    // Call Of Paylines Ghosts
                    if (line.Contains("<ComboSetList>")) plCnt=paylines();

                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == '>' && line.Substring(i + 1) != "")
                        {
                            i++;
                            //Foraging values between the tags - data between '>' and '<'
                            buff = "";
                            for (; line[i] != '<'; i++)
                            {
                                if (line[i] == ' ') continue;
                                buff += line[i];
                            }
                            //Writes data WRT Jumper : false - in text file, truew - in Excel Sheet
                            if (!jumpFlag) sw.Write("    " + buff);
                            else writeInExcel(r, c, buff);
                            c++;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    c = 2; // reseting coloumn for the next row
                    if (line.Contains("") && !jumpFlag) sw.WriteLine("");
                }
                System.Diagnostics.Debug.WriteLine("Success Obbt");
            }
            catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine("Obtainer Exception : " + ex);
                MessageBox.Show("Exception" + ex +" ::: Unable to Read/Write Test File");
            }
        }


        int paylines()
        {
            int plCnt = 0;
            if (jumpFlag) { exlProgs.Value = 60; pBLab.Text = "In Progress ...60%"; }
            try
            {
                while ((line = sr.ReadLine()) != null)
                {
                    //return to weights and values obtainer
                    if (line.Contains("</ComboSetList>")) 
                        if(!jumpFlag) return 0;        //return 0 for text file
                        else { exlProgs.Value = 90; pBLab.Text = "In Progress ...90%"; return plCnt; }             //return playlines count for calculation of row index for Excel docx

                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == '>' && line.Substring(i + 1) != "")
                        {
                            i++;

                            //Foraging values between the tags - data between '>' and '<'
                            buff = "";
                            for (; line[i] != '<'; i++)
                            {
                                if (line[i] == ' ') continue;
                                buff += line[i];
                            }
                            //writing payline data in next coloum 
                            c++;
                            //Writes data WRT Jumper : false - in text file, truew - in Excel Sheet
                            if (!jumpFlag) sw.Write("    " + buff);
                            else writeInExcel(r, c, buff);
                        }
                        else
                        {
                            continue;
                        }
                    }

                    //formatting - Creating New line for text OR new Row for Excel and Coloumn reset
                    if (line.Contains("</PaylineCombo>") || line.Contains("</ScatterCombo>") || line.Contains("</CountScatterCombo>") || line.Contains("</AnywaysCombo>"))
                    {
                        if(!jumpFlag) sw.WriteLine("");
                        else { r++; c = 2; plCnt++; }
                    }
                    if(line.Contains("</PaylineComboSet>") || line.Contains("</ScatterComboSet>") || line.Contains("</CountScatterComboSet>") || line.Contains("</AnywaysComboSet>"))
                    {
                        if (!jumpFlag) sw.WriteLine("");
                        else { r++; c = 2; plCnt++; }
                    }
                    if (line.Contains("</Identifier>"))
                    {
                        if (!jumpFlag) { sw.WriteLine(""); sw.WriteLine(""); }
                        else { r += 2; c = 2; plCnt += 2; }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Payline Exception : " + ex);
                MessageBox.Show("Exception" + ex +" ::: Unable to read/write text file");
            }

            if (!jumpFlag) return 0;
            else return plCnt;
        }


        internal void writeInExcel(int r,int c,string buff)
        {
            try
            {
                //Adding data in Cells
                xlWS.Cells[r, c] = buff;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exceler Exception : " + ex);
                MessageBox.Show("Exception" + ex +" ::: Unable to Write Excel File");
            }
        }


        internal void excelSave()
        {
            try
            {
                //Save and Close
                xlWB.SaveAs(desPath);
                xlWB.Close();
                xlApp.Quit();
                exlProgs.Value = 100;
                pBLab.Text = "Complete";
                MessageBox.Show("Success. Output Location : " + desPath);
                //Closing all Excel Communications
                Marshal.ReleaseComObject(xlWS);
                Marshal.ReleaseComObject(xlWB);
                Marshal.ReleaseComObject(xlApp);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Excel Saver Exception : " + ex);
                MessageBox.Show("Exception" + ex +" ::: Unable to Save Excel File");
            }
        }


        internal void initProgBar(System.Windows.Forms.ProgressBar PB,System.Windows.Forms.Label Label)
        {
            exlProgs = PB;
            pBLab = Label;
        }


    }
}
