namespace filestream_demo
{
    public partial class ReadWriteFile : Form
    {
        public ReadWriteFile()
        {
            InitializeComponent();
        }

        private async void btnReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                btnReadFile.Enabled = false;
                string noiDung = await File.ReadAllTextAsync(openFileDialog.FileName);
                txtResult.Text = noiDung;
                btnReadFile.Enabled = true;
            }
        }

        private async void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                await File.WriteAllTextAsync(saveFileDialog.FileName, txtResult.Text);
                MessageBox.Show("Ghi file thành công!");
            }
        }

        private void btnReadFileStream_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                btnReadFileStream.Enabled = false;
                ReadFileStream(openFileDialog.FileName);
                btnReadFileStream.Enabled = true;
            }

        }

        private void ReadFileStream(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    txtResult.Text = sr.ReadToEnd();
                }
            }
        }

        private void btnWriteFileStream_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.Write(txtResult.Text);
                    }
                }
                MessageBox.Show("Ghi file thành công!");
            }
        }
    }
}
