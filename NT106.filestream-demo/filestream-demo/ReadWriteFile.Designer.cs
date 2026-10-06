namespace filestream_demo
{
    partial class ReadWriteFile
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
            txtResult = new RichTextBox();
            btnWrite = new Button();
            btnReadFile = new Button();
            btnReadFileStream = new Button();
            btnWriteFileStream = new Button();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.Location = new Point(24, 21);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(1455, 552);
            txtResult.TabIndex = 0;
            txtResult.Text = "";
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(219, 713);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(217, 46);
            btnWrite.TabIndex = 1;
            btnWrite.Text = "Write using File";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // btnReadFile
            // 
            btnReadFile.Location = new Point(219, 608);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(217, 46);
            btnReadFile.TabIndex = 2;
            btnReadFile.Text = "Read using File";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // btnReadFileStream
            // 
            btnReadFileStream.Location = new Point(952, 619);
            btnReadFileStream.Name = "btnReadFileStream";
            btnReadFileStream.Size = new Size(262, 46);
            btnReadFileStream.TabIndex = 3;
            btnReadFileStream.Text = "Read using FileStream";
            btnReadFileStream.UseVisualStyleBackColor = true;
            btnReadFileStream.Click += btnReadFileStream_Click;
            // 
            // btnWriteFileStream
            // 
            btnWriteFileStream.Location = new Point(952, 713);
            btnWriteFileStream.Name = "btnWriteFileStream";
            btnWriteFileStream.Size = new Size(262, 46);
            btnWriteFileStream.TabIndex = 4;
            btnWriteFileStream.Text = "Write using FileStream";
            btnWriteFileStream.UseVisualStyleBackColor = true;
            btnWriteFileStream.Click += btnWriteFileStream_Click;
            // 
            // ReadWriteFile
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1511, 805);
            Controls.Add(btnWriteFileStream);
            Controls.Add(btnReadFileStream);
            Controls.Add(btnReadFile);
            Controls.Add(btnWrite);
            Controls.Add(txtResult);
            Name = "ReadWriteFile";
            Text = "FileStream Demo";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txtResult;
        private Button btnWrite;
        private Button btnReadFile;
        private Button btnReadFileStream;
        private Button btnWriteFileStream;
    }
}
