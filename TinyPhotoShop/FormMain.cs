using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyPhotoShop
{
    public partial class FormMain : Form
    {
        private string sSuffix;
        private const int TextBoxBlinkTimes = 4;
        private static float flt_ScalePercent = 0;
        private static Rectangle rectOut;
        public static Color textBoxOriginalBackColor = Color.White;
        private static int FilesCounts = 0;

        public FormMain()
        {
            InitializeComponent();
        }

        private void button_OpenFiles_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FilesCounts += openFileDialog1.FileNames.Count();

                foreach (String sFileName in openFileDialog1.FileNames)
                {
                    textBox_OpenFiles.Lines.Append(sFileName + Environment.NewLine);
                }

                textBox_ProcessingInfo.Lines.Append(Environment.NewLine + ">>> " + FilesCounts + " Files added");
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_OutputDir.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            //
            //Check all necessary options before process
            //

            if(textBox_OpenFiles.TextLength < 8) //Min file path like: c:\1.jpg
            {
                textBox_ProcessingInfo.AppendText("Please select files" + Environment.NewLine);
                return;
            }

            try
            {
                //check scale percentage
                NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
                nfi.NumberDecimalDigits = 3;
                flt_ScalePercent = float.Parse(textBox_ScalePercentage.Text, nfi);
                if (flt_ScalePercent <= 0 || flt_ScalePercent >= 100)
                {
                    textBox_ProcessingInfo.AppendText("The Scal Percentage you input: [ " + flt_ScalePercent.ToString() + " ] supporse between 0 - 100\r\n");
                    return;
                }
                flt_ScalePercent /= 100;
            } 
            catch (Exception ec)
            {
                textBox_ProcessingInfo.AppendText(Environment.NewLine + ">>> Scale Number error :" + ec.ToString());
                return;
            }

            
            //check output dir, string must contains a root drive like c:\ or d:\
            if(Path.IsPathRooted(textBox_OutputDir.Text) == true)
            {
                if (Directory.Exists(textBox_OutputDir.Text) == false)
                {
                    try
                    {
                        DialogResult dialogCreateDir = MessageBox.Show(
                                                        "Create New Folder named: ["
                                                        + Path.GetFileNameWithoutExtension(textBox_OutputDir.Text) + " ]",
                                                        "This directory does NOT exist",
                                                        MessageBoxButtons.YesNo);
                        if (dialogCreateDir == DialogResult.Yes)
                        {
                            //create dir
                            DirectoryInfo di_NewOutputDir = Directory.CreateDirectory(textBox_OutputDir.Text);

                            //create failed, return
                            if (Directory.Exists(textBox_OutputDir.Text) == false)
                                return;
                        }
                        else
                        {
                            return;
                        }
                    }
                    catch (Exception ec)
                    {
                        textBox_ProcessingInfo.AppendText(Environment.NewLine + ">>> Output Directory error :" + ec.ToString() + Environment.NewLine);
                        return;
                    }
                }
            }
            else
            {
                textBox_ProcessingInfo.AppendText(Environment.NewLine + "Please use rooted path for output");
                return;
            }


            //enumerate all files
            try
            {
                //remove last line before process
                textBox_OpenFiles.Text = textBox_OpenFiles.Text.Remove(textBox_OpenFiles.Text.LastIndexOf(Environment.NewLine));
                foreach (String sFile in textBox_OpenFiles.Lines)
                {
                    //minimum file path e.g: [ C:\a ] length is 4
                    if (sFile.Length >= 4 && File.Exists(sFile)) //process every file
                    {
                        //show processing info
                        textBox_ProcessingInfo.AppendText(Environment.NewLine + "Processing :" + sFile);

                        //load source file as a Bitmap
                        Bitmap bmSrcFile = new Bitmap(sFile);
                        rectOut = new Rectangle(0, 0, (int)(bmSrcFile.Width * flt_ScalePercent), (int)(bmSrcFile.Height * flt_ScalePercent));

                        //resize
                        Bitmap bmSrcFileCropped = new Bitmap(bmSrcFile, rectOut.Size);

                        //change format
                        Bitmap bmDstFile = bmSrcFileCropped.Clone(rectOut, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                        sSuffix = textBoxSuffix.Text.Length > 0 ? textBoxSuffix.Text : "_cropped.jpg";
                        bmDstFile.Save(textBox_OutputDir.Text + '\\' + Path.GetFileNameWithoutExtension(sFile) + sSuffix, ImageFormat.Jpeg);
                    }
                }
            }
            catch (Exception ec)
            {
                textBox_ProcessingInfo.AppendText(Environment.NewLine + ">>> File Input error :" + ec.ToString());
                return;
            }

        } //button_Start_Click()

        private void buttonClearInputFilesList_Click(object sender, EventArgs e)
        {
            textBox_OpenFiles.Clear();
            FilesCounts = 0;
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {

        }

        private void pictureBox_Preview_Click(object sender, EventArgs e)
        {

        }
    }
}
