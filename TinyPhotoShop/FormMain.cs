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
        private const int TextBoxBlinkTimes = 4;
        private static int blinkTimeCounter = TextBoxBlinkTimes;
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
            //
            //check before continue
            //
            if(textBox_OpenFiles.TextLength < 4)    //input not qualified
            {
                //an absolute file path suppose longer then 4 chars, e.g: "c:\a"
                textBox_ProcessingInfo.AppendText("Error: [ " + textBox_OpenFiles.Text + " ] is not a file(s)" + "\r\n");

                //store original color
                textBoxOriginalBackColor = textBox_OpenFiles.BackColor;

                //attach a Tag and triger the timer
                timerPromptError.Tag = "input_files_error";
                timerPromptError.Enabled = true;
                return;
            }

            if(textBox_OutputDir.TextLength < 3)    //output not qualified
            {
                //an absolute dir path suppose longer then 3 chars, e.g: "c:\"
                textBox_ProcessingInfo.AppendText("Error: [ " + textBox_OutputDir.Text + " ] is not a directory" + "\r\n");

                //store original color
                textBoxOriginalBackColor = textBox_OutputDir.BackColor;

                //attach a Tag and triger the timer
                timerPromptError.Tag = "output_dir_error";
                timerPromptError.Enabled = true;
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

        private void timerPromptError_Tick(object sender, EventArgs e)
        {
            //
            //TODO: this is a piece of shit code, I apologize, will optimize it later
            //
            Timer t = sender as Timer;
            string s = t.Tag as string;

            if (s != null && s.Equals("input_files_error"))
            {
                //Test
                textBox_ProcessingInfo.AppendText(s + "\r\n");
                if (blinkTimeCounter > 0)
                {
                    if (textBox_OpenFiles.BackColor == textBoxOriginalBackColor)
                        textBox_OpenFiles.BackColor = Color.Red;
                    else
                        textBox_OpenFiles.BackColor = textBoxOriginalBackColor;

                    blinkTimeCounter--;
                }
                else
                {
                    blinkTimeCounter = TextBoxBlinkTimes;
                    timerPromptError.Enabled = false;
                }
            } 
            else if (s != null && s.Equals("output_dir_error"))
            {
                //Test
                textBox_ProcessingInfo.AppendText(s + "\r\n");
                if (blinkTimeCounter > 0)
                {
                    if (textBox_OutputDir.BackColor == textBoxOriginalBackColor)
                        textBox_OutputDir.BackColor = Color.Red;
                    else
                        textBox_OutputDir.BackColor = textBoxOriginalBackColor;

                    blinkTimeCounter--;
                }
                else
                {
                    blinkTimeCounter = TextBoxBlinkTimes;
                    timerPromptError.Enabled = false;
                }
            }
        }

        private void buttonClearInputFilesList_Click(object sender, EventArgs e)
        {
            textBox_OpenFiles.Clear();
        }
    }
}
