
namespace TinyPhotoShop
{
    partial class Form1
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
            this.groupBox_InputFiles = new System.Windows.Forms.GroupBox();
            this.groupBox_PhotoReview = new System.Windows.Forms.GroupBox();
            this.groupBox_OutputOptions = new System.Windows.Forms.GroupBox();
            this.groupBox_Output_Dir = new System.Windows.Forms.GroupBox();
            this.groupBox_Processing = new System.Windows.Forms.GroupBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.textBox_ProcessingInfo = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox_Processing.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_InputFiles
            // 
            this.groupBox_InputFiles.Location = new System.Drawing.Point(12, 60);
            this.groupBox_InputFiles.Name = "groupBox_InputFiles";
            this.groupBox_InputFiles.Size = new System.Drawing.Size(808, 174);
            this.groupBox_InputFiles.TabIndex = 0;
            this.groupBox_InputFiles.TabStop = false;
            this.groupBox_InputFiles.Text = "Input Files";
            // 
            // groupBox_PhotoReview
            // 
            this.groupBox_PhotoReview.Location = new System.Drawing.Point(842, 64);
            this.groupBox_PhotoReview.Name = "groupBox_PhotoReview";
            this.groupBox_PhotoReview.Size = new System.Drawing.Size(203, 170);
            this.groupBox_PhotoReview.TabIndex = 1;
            this.groupBox_PhotoReview.TabStop = false;
            this.groupBox_PhotoReview.Text = "Current Processing";
            // 
            // groupBox_OutputOptions
            // 
            this.groupBox_OutputOptions.Location = new System.Drawing.Point(12, 247);
            this.groupBox_OutputOptions.Name = "groupBox_OutputOptions";
            this.groupBox_OutputOptions.Size = new System.Drawing.Size(203, 170);
            this.groupBox_OutputOptions.TabIndex = 2;
            this.groupBox_OutputOptions.TabStop = false;
            this.groupBox_OutputOptions.Text = "Output Options";
            // 
            // groupBox_Output_Dir
            // 
            this.groupBox_Output_Dir.Location = new System.Drawing.Point(265, 247);
            this.groupBox_Output_Dir.Name = "groupBox_Output_Dir";
            this.groupBox_Output_Dir.Size = new System.Drawing.Size(555, 170);
            this.groupBox_Output_Dir.TabIndex = 3;
            this.groupBox_Output_Dir.TabStop = false;
            this.groupBox_Output_Dir.Text = "Output Directory";
            // 
            // groupBox_Processing
            // 
            this.groupBox_Processing.Controls.Add(this.progressBar1);
            this.groupBox_Processing.Controls.Add(this.textBox_ProcessingInfo);
            this.groupBox_Processing.Location = new System.Drawing.Point(12, 445);
            this.groupBox_Processing.Name = "groupBox_Processing";
            this.groupBox_Processing.Size = new System.Drawing.Size(1049, 134);
            this.groupBox_Processing.TabIndex = 4;
            this.groupBox_Processing.TabStop = false;
            this.groupBox_Processing.Text = "Processing :";
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(842, 247);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(203, 170);
            this.button_Start.TabIndex = 5;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            // 
            // textBox_ProcessingInfo
            // 
            this.textBox_ProcessingInfo.Location = new System.Drawing.Point(0, 49);
            this.textBox_ProcessingInfo.Multiline = true;
            this.textBox_ProcessingInfo.Name = "textBox_ProcessingInfo";
            this.textBox_ProcessingInfo.Size = new System.Drawing.Size(1049, 90);
            this.textBox_ProcessingInfo.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 29);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1043, 14);
            this.progressBar1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 591);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.groupBox_Processing);
            this.Controls.Add(this.groupBox_Output_Dir);
            this.Controls.Add(this.groupBox_OutputOptions);
            this.Controls.Add(this.groupBox_PhotoReview);
            this.Controls.Add(this.groupBox_InputFiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_Processing.ResumeLayout(false);
            this.groupBox_Processing.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_InputFiles;
        private System.Windows.Forms.GroupBox groupBox_PhotoReview;
        private System.Windows.Forms.GroupBox groupBox_OutputOptions;
        private System.Windows.Forms.GroupBox groupBox_Output_Dir;
        private System.Windows.Forms.GroupBox groupBox_Processing;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox_ProcessingInfo;
        private System.Windows.Forms.Button button_Start;
    }
}

