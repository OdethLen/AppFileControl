namespace AppFileControl
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
            btnSelectFolder = new Button();
            txtFolder = new TextBox();
            btnProcessFolder = new Button();
            txtProcesFileNumber = new TextBox();
            btnOpenTextFile = new Button();
            txtContain = new TextBox();
            btnSaveTextFile = new Button();
            btnSaveWord = new Button();
            txtDoc = new TextBox();
            SuspendLayout();
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelectFolder.Location = new Point(12, 31);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(122, 27);
            btnSelectFolder.TabIndex = 0;
            btnSelectFolder.Text = "Select Folder ";
            btnSelectFolder.UseVisualStyleBackColor = true;
            btnSelectFolder.Click += btnSelectFolder_Click;
            // 
            // txtFolder
            // 
            txtFolder.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFolder.Location = new Point(140, 31);
            txtFolder.Name = "txtFolder";
            txtFolder.ReadOnly = true;
            txtFolder.Size = new Size(379, 27);
            txtFolder.TabIndex = 1;
            // 
            // btnProcessFolder
            // 
            btnProcessFolder.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProcessFolder.Location = new Point(12, 97);
            btnProcessFolder.Name = "btnProcessFolder";
            btnProcessFolder.Size = new Size(122, 27);
            btnProcessFolder.TabIndex = 2;
            btnProcessFolder.Text = "Process Folder";
            btnProcessFolder.UseVisualStyleBackColor = true;
            btnProcessFolder.Click += btnProcessFolder_Click;
            // 
            // txtProcesFileNumber
            // 
            txtProcesFileNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProcesFileNumber.Location = new Point(140, 97);
            txtProcesFileNumber.Name = "txtProcesFileNumber";
            txtProcesFileNumber.ReadOnly = true;
            txtProcesFileNumber.Size = new Size(379, 27);
            txtProcesFileNumber.TabIndex = 3;
            // 
            // btnOpenTextFile
            // 
            btnOpenTextFile.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpenTextFile.Location = new Point(12, 166);
            btnOpenTextFile.Name = "btnOpenTextFile";
            btnOpenTextFile.Size = new Size(122, 28);
            btnOpenTextFile.TabIndex = 4;
            btnOpenTextFile.Text = "Open Text File";
            btnOpenTextFile.UseVisualStyleBackColor = true;
            btnOpenTextFile.Click += btnOpenTextFile_Click;
            // 
            // txtContain
            // 
            txtContain.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContain.Location = new Point(140, 166);
            txtContain.Multiline = true;
            txtContain.Name = "txtContain";
            txtContain.ReadOnly = true;
            txtContain.Size = new Size(476, 178);
            txtContain.TabIndex = 5;
            // 
            // btnSaveTextFile
            // 
            btnSaveTextFile.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveTextFile.Location = new Point(12, 377);
            btnSaveTextFile.Name = "btnSaveTextFile";
            btnSaveTextFile.Size = new Size(122, 28);
            btnSaveTextFile.TabIndex = 6;
            btnSaveTextFile.Text = "Save Text File";
            btnSaveTextFile.UseVisualStyleBackColor = true;
            btnSaveTextFile.Click += btnSaveTextFile_Click;
            // 
            // btnSaveWord
            // 
            btnSaveWord.Location = new Point(752, 35);
            btnSaveWord.Name = "btnSaveWord";
            btnSaveWord.Size = new Size(75, 23);
            btnSaveWord.TabIndex = 7;
            btnSaveWord.Text = "Save Word";
            btnSaveWord.UseVisualStyleBackColor = true;
            btnSaveWord.Click += btnSaveWord_Click;
            // 
            // txtDoc
            // 
            txtDoc.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDoc.Location = new Point(648, 64);
            txtDoc.Multiline = true;
            txtDoc.Name = "txtDoc";
            txtDoc.Size = new Size(290, 153);
            txtDoc.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 463);
            Controls.Add(txtDoc);
            Controls.Add(btnSaveWord);
            Controls.Add(btnSaveTextFile);
            Controls.Add(txtContain);
            Controls.Add(btnOpenTextFile);
            Controls.Add(txtProcesFileNumber);
            Controls.Add(btnProcessFolder);
            Controls.Add(txtFolder);
            Controls.Add(btnSelectFolder);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectFolder;
        private TextBox txtFolder;
        private Button btnProcessFolder;
        private TextBox txtProcesFileNumber;
        private Button btnOpenTextFile;
        private TextBox txtContain;
        private Button btnSaveTextFile;
        private Button btnSaveWord;
        private TextBox txtDoc;
    }
}
