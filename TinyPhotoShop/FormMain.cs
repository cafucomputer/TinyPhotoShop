using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyPhotoShop
{
    public partial class FormMain : Form
    {
        public static Int32 textBoxBlinkTimes = 4;
        public static Color textBoxOriginalBackColor = Color.White;

        public FormMain()
        {
            InitializeComponent();
        }

        private void button_OpenFiles_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (String sFileName in openFileDialog1.FileNames)
                {
                    textBox_OpenFiles.AppendText(sFileName + "\r\n");
                }
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
            //check before continue
            if(textBox_OpenFiles.TextLength < 4)
            {
                //an absolute file path suppose longer then 4 chars e.g  "c:\a"
                textBox_ProcessingInfo.AppendText("Error: [ " + textBox_OpenFiles.Text + " ] is not a file(s)" + "\r\n");
                return;
            }
            if(textBox_OutputDir.TextLength < 3)
            {
                //an absolute dir path suppose longer then 3 chars e.g  "c:\"
                textBox_ProcessingInfo.AppendText("Error: [ " + textBox_OutputDir.Text + " ] is not a directory" + "\r\n");

                //store original color
                textBoxOriginalBackColor = textBox_OutputDir.BackColor;

                timer1.Enabled = true;
                timer1.Start();
                return;
            }

            //enumerate all files
            foreach (String sFile in textBox_OpenFiles.Lines)
            {
                //an absolute file path suppose longer then 4 chars e.g  "c:\a"
                if (sFile.Length >= 4)
                {
                    //show processing info
                    textBox_ProcessingInfo.AppendText("Processing " + sFile + "\r\n");
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(textBoxBlinkTimes > 0)
            {
                if (textBox_OutputDir.BackColor == textBoxOriginalBackColor)
                    textBox_OutputDir.BackColor = Color.Red;
                else
                    textBox_OutputDir.BackColor = textBoxOriginalBackColor;

                textBoxBlinkTimes --;
            } else {
                textBoxBlinkTimes = 4;
                timer1.Stop();
            }
        }
    }
}
