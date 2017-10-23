using System;
using System.Windows.Forms;

namespace FileListParser
{
    public partial class Form1 : Form
    {
        private readonly IFileParser mFileParser;

        public Form1()
        {
            mFileParser = new FileParser();

            InitializeComponent();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            var inPath = txtFilePath.Text;
            var outPath = txtOutPath.Text;
            mFileParser.ParseFile(inPath, outPath);
        }
    }
}
