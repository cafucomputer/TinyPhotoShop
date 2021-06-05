
namespace TinyPhotoShop
{
    partial class FormMain
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
            this.buttonClearInputFilesList = new System.Windows.Forms.Button();
            this.button_OpenFiles = new System.Windows.Forms.Button();
            this.textBox_OpenFiles = new System.Windows.Forms.TextBox();
            this.groupBox_PhotoReview = new System.Windows.Forms.GroupBox();
            this.pictureBox_Preview = new System.Windows.Forms.PictureBox();
            this.groupBox_MiscOptions = new System.Windows.Forms.GroupBox();
            this.labelSuffix = new System.Windows.Forms.Label();
            this.textBoxSuffix = new System.Windows.Forms.TextBox();
            this.checkBox_AddWatermark = new System.Windows.Forms.CheckBox();
            this.checkBox_RemoveEXIF = new System.Windows.Forms.CheckBox();
            this.groupBox_Output_Dir = new System.Windows.Forms.GroupBox();
            this.groupBox_Scale = new System.Windows.Forms.GroupBox();
            this.textBox_ScalePercentage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_OutputDir = new System.Windows.Forms.TextBox();
            this.groupBox_Processing = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox_ProcessingInfo = new System.Windows.Forms.TextBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.groupBox_Language = new System.Windows.Forms.GroupBox();
            this.radioButton_Chinese = new System.Windows.Forms.RadioButton();
            this.radioButton_English = new System.Windows.Forms.RadioButton();
            this.label_Version = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.labelFormat = new System.Windows.Forms.Label();
            this.radioButtonFormatJPG = new System.Windows.Forms.RadioButton();
            this.radioButtonFormatPNG = new System.Windows.Forms.RadioButton();
            this.groupBox_InputFiles.SuspendLayout();
            this.groupBox_PhotoReview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Preview)).BeginInit();
            this.groupBox_MiscOptions.SuspendLayout();
            this.groupBox_Output_Dir.SuspendLayout();
            this.groupBox_Scale.SuspendLayout();
            this.groupBox_Processing.SuspendLayout();
            this.groupBox_Language.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_InputFiles
            // 
            this.groupBox_InputFiles.Controls.Add(this.buttonClearInputFilesList);
            this.groupBox_InputFiles.Controls.Add(this.button_OpenFiles);
            this.groupBox_InputFiles.Controls.Add(this.textBox_OpenFiles);
            this.groupBox_InputFiles.Location = new System.Drawing.Point(12, 70);
            this.groupBox_InputFiles.Name = "groupBox_InputFiles";
            this.groupBox_InputFiles.Size = new System.Drawing.Size(824, 164);
            this.groupBox_InputFiles.TabIndex = 1;
            this.groupBox_InputFiles.TabStop = false;
            this.groupBox_InputFiles.Text = "Input Files (all files listed here will be edited)↓";
            // 
            // buttonClearInputFilesList
            // 
            this.buttonClearInputFilesList.Location = new System.Drawing.Point(724, 116);
            this.buttonClearInputFilesList.Name = "buttonClearInputFilesList";
            this.buttonClearInputFilesList.Size = new System.Drawing.Size(94, 34);
            this.buttonClearInputFilesList.TabIndex = 2;
            this.buttonClearInputFilesList.Text = "Clear";
            this.buttonClearInputFilesList.UseVisualStyleBackColor = true;
            this.buttonClearInputFilesList.Click += new System.EventHandler(this.buttonClearInputFilesList_Click);
            // 
            // button_OpenFiles
            // 
            this.button_OpenFiles.Location = new System.Drawing.Point(724, 29);
            this.button_OpenFiles.Name = "button_OpenFiles";
            this.button_OpenFiles.Size = new System.Drawing.Size(94, 81);
            this.button_OpenFiles.TabIndex = 1;
            this.button_OpenFiles.Text = "Add File(s)";
            this.button_OpenFiles.UseVisualStyleBackColor = true;
            this.button_OpenFiles.Click += new System.EventHandler(this.button_OpenFiles_Click);
            // 
            // textBox_OpenFiles
            // 
            this.textBox_OpenFiles.Location = new System.Drawing.Point(0, 29);
            this.textBox_OpenFiles.Multiline = true;
            this.textBox_OpenFiles.Name = "textBox_OpenFiles";
            this.textBox_OpenFiles.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_OpenFiles.Size = new System.Drawing.Size(718, 135);
            this.textBox_OpenFiles.TabIndex = 0;
            this.textBox_OpenFiles.WordWrap = false;
            // 
            // groupBox_PhotoReview
            // 
            this.groupBox_PhotoReview.Controls.Add(this.pictureBox_Preview);
            this.groupBox_PhotoReview.Location = new System.Drawing.Point(842, 64);
            this.groupBox_PhotoReview.Name = "groupBox_PhotoReview";
            this.groupBox_PhotoReview.Size = new System.Drawing.Size(203, 170);
            this.groupBox_PhotoReview.TabIndex = 1;
            this.groupBox_PhotoReview.TabStop = false;
            this.groupBox_PhotoReview.Text = "Current Processing ↓";
            // 
            // pictureBox_Preview
            // 
            this.pictureBox_Preview.Location = new System.Drawing.Point(3, 26);
            this.pictureBox_Preview.Name = "pictureBox_Preview";
            this.pictureBox_Preview.Size = new System.Drawing.Size(200, 144);
            this.pictureBox_Preview.TabIndex = 0;
            this.pictureBox_Preview.TabStop = false;
            // 
            // groupBox_MiscOptions
            // 
            this.groupBox_MiscOptions.Controls.Add(this.labelSuffix);
            this.groupBox_MiscOptions.Controls.Add(this.textBoxSuffix);
            this.groupBox_MiscOptions.Controls.Add(this.checkBox_AddWatermark);
            this.groupBox_MiscOptions.Controls.Add(this.checkBox_RemoveEXIF);
            this.groupBox_MiscOptions.Location = new System.Drawing.Point(12, 247);
            this.groupBox_MiscOptions.Name = "groupBox_MiscOptions";
            this.groupBox_MiscOptions.Size = new System.Drawing.Size(277, 170);
            this.groupBox_MiscOptions.TabIndex = 2;
            this.groupBox_MiscOptions.TabStop = false;
            this.groupBox_MiscOptions.Text = "Misc Options ↓";
            // 
            // labelSuffix
            // 
            this.labelSuffix.AutoSize = true;
            this.labelSuffix.Location = new System.Drawing.Point(3, 129);
            this.labelSuffix.Name = "labelSuffix";
            this.labelSuffix.Size = new System.Drawing.Size(66, 24);
            this.labelSuffix.TabIndex = 10;
            this.labelSuffix.Text = "Suffiix:";
            // 
            // textBoxSuffix
            // 
            this.textBoxSuffix.Location = new System.Drawing.Point(75, 124);
            this.textBoxSuffix.Name = "textBoxSuffix";
            this.textBoxSuffix.Size = new System.Drawing.Size(196, 30);
            this.textBoxSuffix.TabIndex = 9;
            this.textBoxSuffix.Text = "_cropped.jpg";
            // 
            // checkBox_AddWatermark
            // 
            this.checkBox_AddWatermark.AutoSize = true;
            this.checkBox_AddWatermark.Location = new System.Drawing.Point(3, 60);
            this.checkBox_AddWatermark.Name = "checkBox_AddWatermark";
            this.checkBox_AddWatermark.Size = new System.Drawing.Size(174, 28);
            this.checkBox_AddWatermark.TabIndex = 8;
            this.checkBox_AddWatermark.Text = "Add Watermark";
            this.checkBox_AddWatermark.UseVisualStyleBackColor = true;
            // 
            // checkBox_RemoveEXIF
            // 
            this.checkBox_RemoveEXIF.AutoSize = true;
            this.checkBox_RemoveEXIF.Checked = true;
            this.checkBox_RemoveEXIF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_RemoveEXIF.Location = new System.Drawing.Point(3, 26);
            this.checkBox_RemoveEXIF.Name = "checkBox_RemoveEXIF";
            this.checkBox_RemoveEXIF.Size = new System.Drawing.Size(147, 28);
            this.checkBox_RemoveEXIF.TabIndex = 7;
            this.checkBox_RemoveEXIF.Text = "Remove EXIF";
            this.checkBox_RemoveEXIF.UseVisualStyleBackColor = true;
            // 
            // groupBox_Output_Dir
            // 
            this.groupBox_Output_Dir.Controls.Add(this.groupBox_Scale);
            this.groupBox_Output_Dir.Controls.Add(this.button_Save);
            this.groupBox_Output_Dir.Controls.Add(this.textBox_OutputDir);
            this.groupBox_Output_Dir.Location = new System.Drawing.Point(296, 247);
            this.groupBox_Output_Dir.Name = "groupBox_Output_Dir";
            this.groupBox_Output_Dir.Size = new System.Drawing.Size(540, 170);
            this.groupBox_Output_Dir.TabIndex = 3;
            this.groupBox_Output_Dir.TabStop = false;
            this.groupBox_Output_Dir.Text = "Output Directory (Save edited Photos to This Folder)↓";
            // 
            // groupBox_Scale
            // 
            this.groupBox_Scale.Controls.Add(this.radioButtonFormatPNG);
            this.groupBox_Scale.Controls.Add(this.textBox_ScalePercentage);
            this.groupBox_Scale.Controls.Add(this.radioButtonFormatJPG);
            this.groupBox_Scale.Controls.Add(this.label1);
            this.groupBox_Scale.Controls.Add(this.labelFormat);
            this.groupBox_Scale.Location = new System.Drawing.Point(6, 65);
            this.groupBox_Scale.Name = "groupBox_Scale";
            this.groupBox_Scale.Size = new System.Drawing.Size(528, 99);
            this.groupBox_Scale.TabIndex = 5;
            this.groupBox_Scale.TabStop = false;
            this.groupBox_Scale.Text = "Scale :";
            // 
            // textBox_ScalePercentage
            // 
            this.textBox_ScalePercentage.Location = new System.Drawing.Point(7, 41);
            this.textBox_ScalePercentage.Name = "textBox_ScalePercentage";
            this.textBox_ScalePercentage.Size = new System.Drawing.Size(95, 30);
            this.textBox_ScalePercentage.TabIndex = 5;
            this.textBox_ScalePercentage.Text = "33.333";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "%";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(440, 29);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(94, 30);
            this.button_Save.TabIndex = 4;
            this.button_Save.Text = "Output";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBox_OutputDir
            // 
            this.textBox_OutputDir.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_OutputDir.Location = new System.Drawing.Point(6, 29);
            this.textBox_OutputDir.Name = "textBox_OutputDir";
            this.textBox_OutputDir.Size = new System.Drawing.Size(428, 30);
            this.textBox_OutputDir.TabIndex = 3;
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
            this.groupBox_Processing.Text = "Processing ↓";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 29);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1049, 14);
            this.progressBar1.TabIndex = 1;
            // 
            // textBox_ProcessingInfo
            // 
            this.textBox_ProcessingInfo.Location = new System.Drawing.Point(0, 49);
            this.textBox_ProcessingInfo.Multiline = true;
            this.textBox_ProcessingInfo.Name = "textBox_ProcessingInfo";
            this.textBox_ProcessingInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_ProcessingInfo.Size = new System.Drawing.Size(1049, 90);
            this.textBox_ProcessingInfo.TabIndex = 0;
            this.textBox_ProcessingInfo.WordWrap = false;
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(842, 247);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(203, 170);
            this.button_Start.TabIndex = 6;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // groupBox_Language
            // 
            this.groupBox_Language.Controls.Add(this.radioButton_Chinese);
            this.groupBox_Language.Controls.Add(this.radioButton_English);
            this.groupBox_Language.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Language.Name = "groupBox_Language";
            this.groupBox_Language.Size = new System.Drawing.Size(824, 52);
            this.groupBox_Language.TabIndex = 1;
            this.groupBox_Language.TabStop = false;
            this.groupBox_Language.Text = "Set Language ↓";
            // 
            // radioButton_Chinese
            // 
            this.radioButton_Chinese.AutoSize = true;
            this.radioButton_Chinese.Location = new System.Drawing.Point(387, 18);
            this.radioButton_Chinese.Name = "radioButton_Chinese";
            this.radioButton_Chinese.Size = new System.Drawing.Size(71, 28);
            this.radioButton_Chinese.TabIndex = 2;
            this.radioButton_Chinese.Text = "中文";
            this.radioButton_Chinese.UseVisualStyleBackColor = true;
            // 
            // radioButton_English
            // 
            this.radioButton_English.AutoSize = true;
            this.radioButton_English.Checked = true;
            this.radioButton_English.Location = new System.Drawing.Point(180, 18);
            this.radioButton_English.Name = "radioButton_English";
            this.radioButton_English.Size = new System.Drawing.Size(97, 28);
            this.radioButton_English.TabIndex = 1;
            this.radioButton_English.TabStop = true;
            this.radioButton_English.Text = "English";
            this.radioButton_English.UseVisualStyleBackColor = true;
            // 
            // label_Version
            // 
            this.label_Version.AutoSize = true;
            this.label_Version.Location = new System.Drawing.Point(854, 30);
            this.label_Version.Name = "label_Version";
            this.label_Version.Size = new System.Drawing.Size(114, 24);
            this.label_Version.TabIndex = 6;
            this.label_Version.Text = "Version : 0.1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Select One or More Photos";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Chose a Directory to Save Photos";
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.UserProfile;
            this.folderBrowserDialog1.UseDescriptionForTitle = true;
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Location = new System.Drawing.Point(159, 26);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(76, 24);
            this.labelFormat.TabIndex = 11;
            this.labelFormat.Text = "Format:";
            // 
            // radioButtonFormatJPG
            // 
            this.radioButtonFormatJPG.AutoSize = true;
            this.radioButtonFormatJPG.Checked = true;
            this.radioButtonFormatJPG.Location = new System.Drawing.Point(241, 29);
            this.radioButtonFormatJPG.Name = "radioButtonFormatJPG";
            this.radioButtonFormatJPG.Size = new System.Drawing.Size(66, 28);
            this.radioButtonFormatJPG.TabIndex = 3;
            this.radioButtonFormatJPG.Text = "JPG";
            this.radioButtonFormatJPG.UseVisualStyleBackColor = true;
            // 
            // radioButtonFormatPNG
            // 
            this.radioButtonFormatPNG.AutoSize = true;
            this.radioButtonFormatPNG.Location = new System.Drawing.Point(313, 29);
            this.radioButtonFormatPNG.Name = "radioButtonFormatPNG";
            this.radioButtonFormatPNG.Size = new System.Drawing.Size(74, 28);
            this.radioButtonFormatPNG.TabIndex = 12;
            this.radioButtonFormatPNG.Text = "PNG";
            this.radioButtonFormatPNG.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 591);
            this.Controls.Add(this.label_Version);
            this.Controls.Add(this.groupBox_Language);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.groupBox_Processing);
            this.Controls.Add(this.groupBox_Output_Dir);
            this.Controls.Add(this.groupBox_MiscOptions);
            this.Controls.Add(this.groupBox_PhotoReview);
            this.Controls.Add(this.groupBox_InputFiles);
            this.Name = "FormMain";
            this.Text = "TinyPhotoShop";
            this.groupBox_InputFiles.ResumeLayout(false);
            this.groupBox_InputFiles.PerformLayout();
            this.groupBox_PhotoReview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Preview)).EndInit();
            this.groupBox_MiscOptions.ResumeLayout(false);
            this.groupBox_MiscOptions.PerformLayout();
            this.groupBox_Output_Dir.ResumeLayout(false);
            this.groupBox_Output_Dir.PerformLayout();
            this.groupBox_Scale.ResumeLayout(false);
            this.groupBox_Scale.PerformLayout();
            this.groupBox_Processing.ResumeLayout(false);
            this.groupBox_Processing.PerformLayout();
            this.groupBox_Language.ResumeLayout(false);
            this.groupBox_Language.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_InputFiles;
        private System.Windows.Forms.GroupBox groupBox_PhotoReview;
        private System.Windows.Forms.GroupBox groupBox_MiscOptions;
        private System.Windows.Forms.GroupBox groupBox_Output_Dir;
        private System.Windows.Forms.GroupBox groupBox_Processing;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox_ProcessingInfo;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.GroupBox groupBox_Language;
        private System.Windows.Forms.RadioButton radioButton_Chinese;
        private System.Windows.Forms.RadioButton radioButton_English;
        private System.Windows.Forms.PictureBox pictureBox_Preview;
        private System.Windows.Forms.Label label_Version;
        private System.Windows.Forms.Button button_OpenFiles;
        private System.Windows.Forms.TextBox textBox_OpenFiles;
        private System.Windows.Forms.CheckBox checkBox_RemoveEXIF;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox_OutputDir;
        private System.Windows.Forms.CheckBox checkBox_AddWatermark;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonClearInputFilesList;
        private System.Windows.Forms.GroupBox groupBox_Scale;
        private System.Windows.Forms.TextBox textBox_ScalePercentage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSuffix;
        private System.Windows.Forms.Label labelSuffix;
        private System.Windows.Forms.RadioButton radioButtonFormatPNG;
        private System.Windows.Forms.RadioButton radioButtonFormatJPG;
        private System.Windows.Forms.Label labelFormat;
    }
}

