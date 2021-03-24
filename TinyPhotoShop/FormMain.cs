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
    }
}
