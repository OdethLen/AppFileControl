using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Windows.Forms;
using System;

namespace AppFileControl


{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select folder";
            folderBrowserDialog.ShowNewFolderButton = false;
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop; //Desktop
            //folderBrowserDialog.SelectedPath = @"C:\";
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            txtFolder.Text = folderBrowserDialog.SelectedPath;

        }

        private void btnProcessFolder_Click(object sender, EventArgs e)
        {
            string[] filesInFolder = Directory.GetFiles(txtFolder.Text);
            txtProcesFileNumber.Text = filesInFolder.Length + "File(s) Processed";

            foreach (string file in filesInFolder)
            {
                string fileName = Path.GetFileName(file);
                string fileExtension = Path.GetExtension(file);

                switch (fileExtension)
                {
                    case ".txt":
                    case ".xlsx":
                    case ".docx":
                    case ".pptx":
                    case ".pdf":
                    case ".epub":

                        if (!Directory.Exists(txtFolder.Text + "\\Docs"))
                        {
                            Directory.CreateDirectory(txtFolder.Text + "\\Docs");
                        }
                        File.Move(file, txtFolder.Text + "\\Docs\\" + fileName);
                        break;

                    case ".png":
                    case ".jpg":
                    case ".jpeg":
                    case ".gif":
                        if (!Directory.Exists(txtFolder.Text + "\\Pics"))
                        {
                            Directory.CreateDirectory(txtFolder.Text + "\\Pics");
                        }
                        File.Move(file, txtFolder.Text + "\\Pics\\" + fileName);
                        break;

                    case ".mp4":
                    case ".mp3":

                        if (!Directory.Exists(txtFolder.Text + "\\Video"))
                        {
                            Directory.CreateDirectory(txtFolder.Text + "\\Video");
                        }
                        File.Move(file, txtFolder.Text + "\\Video\\" + fileName);
                        break;

                    default:
                        File.Move(file, txtFolder.Text + "\\Other\\" + fileName);
                        break;
                }
            }
        }

        private void btnOpenTextFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text Files |*.txt";
            dialog.Title = "Select a Text File";
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            txtContain.Text = File.ReadAllText(dialog.FileName);

        }

        private void btnSaveTextFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text Files |* .txt";
            dialog.Title = "Save the Text File";
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            File.WriteAllText(dialog.FileName, txtContain.Text);
        }

        private void btnSaveWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word Document|*.docx";
            saveFileDialog.Title = "WORD DOCUMENTTT";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }


            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(saveFileDialog.FileName, WordprocessingDocumentType.Document))
            {
                MainDocumentPart MainPart = wordDocument.AddMainDocumentPart();
                MainPart.Document = new Document();
                Body body = MainPart.Document.AppendChild(new Body());
                Paragraph paragraph = body.AppendChild(new Paragraph());
                Run run = paragraph.AppendChild(new Run());
                run.AppendChild(new Text(txtDoc.Text));
                wordDocument.Save();
            }

            MessageBox.Show("Word document saved :D");
        }
    }
}
