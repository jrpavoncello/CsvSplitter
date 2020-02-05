using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsvSplitter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.numPartSizeMB.Maximum = Int32.MaxValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtFilePath.Text = this.openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var filePath = this.txtFilePath.Text;

            if (File.Exists(filePath))
            {
                var fileInfo = new FileInfo(filePath);

                var fileSizeInBytes = fileInfo.Length;

                int mbPerFile = Convert.ToInt32(this.numPartSizeMB.Value);

                // Add one to account for error
                var estNumFilesNeeded = Math.Round(fileSizeInBytes / 1000000.0f / mbPerFile) + 1;

                int lengthOfPaddingNeeded = Convert.ToInt32(Math.Floor(Math.Log10(estNumFilesNeeded))) + 1;

                this.progressBar1.Style = ProgressBarStyle.Marquee;

                Task.Factory.StartNew(() =>
                {
                    using (var sr = new StreamReader(filePath))
                    {
                        var fileDir = Path.GetDirectoryName(filePath);
                        var fileName = Path.GetFileName(filePath);

                        string colHeaders = null;
                        if (this.cbColHead.Checked)
                        {
                            colHeaders = sr.ReadLine();
                        }

                        int fileNum = 0;
                        var filePartWriter = MakeNewFilePart(fileDir, fileName, fileNum, lengthOfPaddingNeeded, colHeaders);

                        float bytesWrittenToPart = 0;

                        while (!sr.EndOfStream)
                        {
                            var line = sr.ReadLine();

                            var lineSizeB = GetAsciiSizeBytes(line);

                            if ((bytesWrittenToPart + lineSizeB) / 1000000.0f >= mbPerFile)
                            {
                                fileNum++;

                                filePartWriter.Close();

                                filePartWriter = MakeNewFilePart(fileDir, fileName, fileNum, lengthOfPaddingNeeded, colHeaders);

                                bytesWrittenToPart = 0;
                                if (colHeaders != null)
                                {
                                    bytesWrittenToPart += GetAsciiSizeBytes(colHeaders);
                                }
                            }

                            filePartWriter.WriteLine(line);

                            bytesWrittenToPart += lineSizeB;
                        }

                        filePartWriter.Close();

                        this.Invoke((MethodInvoker) delegate { this.progressBar1.Style = ProgressBarStyle.Continuous; });
                    }
                });
            }
        }

        private StreamWriter MakeNewFilePart(string fileDir, string fileName, int fileNum, int lengthOfPaddingNeeded, string colHeaders)
        {
            var partFilePath = GenerateNewFilePath(fileDir, fileName, fileNum, lengthOfPaddingNeeded);

            var partFileStream = new StreamWriter(File.Open(partFilePath, FileMode.Create, FileAccess.Write), Encoding.ASCII);

            if (colHeaders != null)
            {
                partFileStream.WriteLine(colHeaders);
            }

            return partFileStream;
        }

        private static string GenerateNewFilePath(string fileDir, string fileName, int fileNum, int lengthOfPaddingNeeded)
        {
            return Path.Combine(
                fileDir,
                fileName.Substring(0, fileName.Length - 4)
                    + fileNum.ToString().PadLeft(lengthOfPaddingNeeded, '0')
                    + ".csv");
        }

        private static int GetAsciiSizeBytes(string line)
        {
            // +2 for the windows line endings \r\n
            return ASCIIEncoding.ASCII.GetByteCount(line) + 2;
        }
    }
}
