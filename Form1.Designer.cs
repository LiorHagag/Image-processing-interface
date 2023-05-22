namespace Assigment2
{
    partial class Form1
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
            this.UploadBT = new System.Windows.Forms.Button();
            this.uploadedFile = new System.Windows.Forms.PictureBox();
            this.PicAfterChange = new System.Windows.Forms.PictureBox();
            this.RemoveeColor = new System.Windows.Forms.Button();
            this.GreyBT = new System.Windows.Forms.Button();
            this.LoadBT = new System.Windows.Forms.Button();
            this.FileNameText = new System.Windows.Forms.TextBox();
            this.ClearImageBT = new System.Windows.Forms.Button();
            this.convolution = new System.Windows.Forms.Button();
            this.LoadingLine = new System.Windows.Forms.ProgressBar();
            this.ColorChoose = new System.Windows.Forms.ComboBox();
            this.MouseMove = new System.Windows.Forms.Label();
            this.ConvoluionBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.uploadedFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAfterChange)).BeginInit();
            this.SuspendLayout();
            // 
            // UploadBT
            // 
            this.UploadBT.Location = new System.Drawing.Point(386, 19);
            this.UploadBT.Margin = new System.Windows.Forms.Padding(2);
            this.UploadBT.Name = "UploadBT";
            this.UploadBT.Size = new System.Drawing.Size(28, 19);
            this.UploadBT.TabIndex = 0;
            this.UploadBT.Text = "...";
            this.UploadBT.UseVisualStyleBackColor = true;
            this.UploadBT.Click += new System.EventHandler(this.UploadBT_Click);
            // 
            // uploadedFile
            // 
            this.uploadedFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uploadedFile.Location = new System.Drawing.Point(16, 56);
            this.uploadedFile.Margin = new System.Windows.Forms.Padding(2);
            this.uploadedFile.Name = "uploadedFile";
            this.uploadedFile.Size = new System.Drawing.Size(415, 303);
            this.uploadedFile.TabIndex = 1;
            this.uploadedFile.TabStop = false;
            this.uploadedFile.Click += new System.EventHandler(this.uploadedFile_Click);
            this.uploadedFile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.uploadedFile_MouseMove);
            // 
            // PicAfterChange
            // 
            this.PicAfterChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicAfterChange.Location = new System.Drawing.Point(592, 56);
            this.PicAfterChange.Margin = new System.Windows.Forms.Padding(2);
            this.PicAfterChange.Name = "PicAfterChange";
            this.PicAfterChange.Size = new System.Drawing.Size(415, 303);
            this.PicAfterChange.TabIndex = 2;
            this.PicAfterChange.TabStop = false;
            this.PicAfterChange.Click += new System.EventHandler(this.PicAfterChange_Click);
            // 
            // RemoveeColor
            // 
            this.RemoveeColor.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RemoveeColor.Location = new System.Drawing.Point(435, 80);
            this.RemoveeColor.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveeColor.Name = "RemoveeColor";
            this.RemoveeColor.Size = new System.Drawing.Size(142, 20);
            this.RemoveeColor.TabIndex = 4;
            this.RemoveeColor.Text = "Remove Color";
            this.RemoveeColor.UseVisualStyleBackColor = true;
            this.RemoveeColor.Click += new System.EventHandler(this.RemoveeColor_Click);
            // 
            // GreyBT
            // 
            this.GreyBT.BackColor = System.Drawing.Color.Snow;
            this.GreyBT.Location = new System.Drawing.Point(435, 115);
            this.GreyBT.Margin = new System.Windows.Forms.Padding(2);
            this.GreyBT.Name = "GreyBT";
            this.GreyBT.Size = new System.Drawing.Size(56, 20);
            this.GreyBT.TabIndex = 5;
            this.GreyBT.Text = "Grey";
            this.GreyBT.UseVisualStyleBackColor = false;
            this.GreyBT.Click += new System.EventHandler(this.GreyBT_Click);
            // 
            // LoadBT
            // 
            this.LoadBT.Location = new System.Drawing.Point(418, 19);
            this.LoadBT.Margin = new System.Windows.Forms.Padding(2);
            this.LoadBT.Name = "LoadBT";
            this.LoadBT.Size = new System.Drawing.Size(56, 19);
            this.LoadBT.TabIndex = 6;
            this.LoadBT.Text = "Load";
            this.LoadBT.UseVisualStyleBackColor = true;
            this.LoadBT.Click += new System.EventHandler(this.LoadBT_Click);
            // 
            // FileNameText
            // 
            this.FileNameText.Location = new System.Drawing.Point(9, 19);
            this.FileNameText.Margin = new System.Windows.Forms.Padding(2);
            this.FileNameText.Name = "FileNameText";
            this.FileNameText.Size = new System.Drawing.Size(365, 20);
            this.FileNameText.TabIndex = 7;
            this.FileNameText.TextChanged += new System.EventHandler(this.FileNameText_TextChanged);
            // 
            // ClearImageBT
            // 
            this.ClearImageBT.Location = new System.Drawing.Point(520, 115);
            this.ClearImageBT.Margin = new System.Windows.Forms.Padding(2);
            this.ClearImageBT.Name = "ClearImageBT";
            this.ClearImageBT.Size = new System.Drawing.Size(56, 19);
            this.ClearImageBT.TabIndex = 8;
            this.ClearImageBT.Text = "Clear";
            this.ClearImageBT.UseVisualStyleBackColor = true;
            this.ClearImageBT.Click += new System.EventHandler(this.ClearImageBT_Click);
            // 
            // convolution
            // 
            this.convolution.Location = new System.Drawing.Point(466, 203);
            this.convolution.Margin = new System.Windows.Forms.Padding(2);
            this.convolution.Name = "convolution";
            this.convolution.Size = new System.Drawing.Size(74, 20);
            this.convolution.TabIndex = 9;
            this.convolution.Text = "Convolution";
            this.convolution.UseVisualStyleBackColor = true;
            this.convolution.Click += new System.EventHandler(this.convolution_Click);
            // 
            // LoadingLine
            // 
            this.LoadingLine.Location = new System.Drawing.Point(368, 384);
            this.LoadingLine.Margin = new System.Windows.Forms.Padding(2);
            this.LoadingLine.Name = "LoadingLine";
            this.LoadingLine.Size = new System.Drawing.Size(274, 19);
            this.LoadingLine.TabIndex = 10;
            this.LoadingLine.Click += new System.EventHandler(this.LoadingLine_Click);
            // 
            // ColorChoose
            // 
            this.ColorChoose.CausesValidation = false;
            this.ColorChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorChoose.FormattingEnabled = true;
            this.ColorChoose.Location = new System.Drawing.Point(435, 56);
            this.ColorChoose.Margin = new System.Windows.Forms.Padding(2);
            this.ColorChoose.Name = "ColorChoose";
            this.ColorChoose.Size = new System.Drawing.Size(143, 21);
            this.ColorChoose.TabIndex = 12;
            this.ColorChoose.SelectedIndexChanged += new System.EventHandler(this.ColorChoose_SelectedIndexChanged);
            // 
            // MouseMove
            // 
            this.MouseMove.AutoSize = true;
            this.MouseMove.Location = new System.Drawing.Point(166, 384);
            this.MouseMove.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MouseMove.Name = "MouseMove";
            this.MouseMove.Size = new System.Drawing.Size(119, 13);
            this.MouseMove.TabIndex = 13;
            this.MouseMove.Text = "Pixels under the mouse:";
            this.MouseMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_MouseMove);
            // 
            // ConvoluionBox
            // 
            this.ConvoluionBox.CausesValidation = false;
            this.ConvoluionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConvoluionBox.FormattingEnabled = true;
            this.ConvoluionBox.Location = new System.Drawing.Point(435, 179);
            this.ConvoluionBox.Margin = new System.Windows.Forms.Padding(2);
            this.ConvoluionBox.Name = "ConvoluionBox";
            this.ConvoluionBox.Size = new System.Drawing.Size(143, 21);
            this.ConvoluionBox.TabIndex = 15;
            this.ConvoluionBox.SelectedIndexChanged += new System.EventHandler(this.ConvoluionBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.RemoveeColor;
            this.ClientSize = new System.Drawing.Size(1025, 468);
            this.Controls.Add(this.ConvoluionBox);
            this.Controls.Add(this.MouseMove);
            this.Controls.Add(this.ColorChoose);
            this.Controls.Add(this.LoadingLine);
            this.Controls.Add(this.convolution);
            this.Controls.Add(this.ClearImageBT);
            this.Controls.Add(this.FileNameText);
            this.Controls.Add(this.LoadBT);
            this.Controls.Add(this.GreyBT);
            this.Controls.Add(this.RemoveeColor);
            this.Controls.Add(this.PicAfterChange);
            this.Controls.Add(this.uploadedFile);
            this.Controls.Add(this.UploadBT);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Pixels changer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uploadedFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAfterChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UploadBT;
        private System.Windows.Forms.PictureBox uploadedFile;
        private System.Windows.Forms.PictureBox PicAfterChange;
        private System.Windows.Forms.Button RemoveeColor;
        private System.Windows.Forms.Button GreyBT;
        private System.Windows.Forms.Button LoadBT;
        private System.Windows.Forms.TextBox FileNameText;
        private System.Windows.Forms.Button ClearImageBT;
        private System.Windows.Forms.Button convolution;
        private System.Windows.Forms.ProgressBar LoadingLine;
        private System.Windows.Forms.ComboBox ColorChoose;
        private System.Windows.Forms.Label MouseMove;
        private System.Windows.Forms.ComboBox ConvoluionBox;
    }
}

