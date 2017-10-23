using System.IO;

namespace FileListParser
{
    public class FileParser : IFileParser
    {
        public void ParseFile(string inPath, string outPath)
        {
            using (StreamWriter outFile = new StreamWriter(outPath))
            {
                foreach (string inLine in File.ReadLines(inPath))
                {
                    string outLine = ConvertLine(inLine);
                    outFile.WriteLine(outLine);
                }
            }
        }

        public string ConvertLine(string inLine)
        {
            var outLine = string.Empty;
            var kbPos = inLine.IndexOf(" KB ");
            if (kbPos > 0)
            {
                inLine = inLine.Substring(0, kbPos);
                var spPos = inLine.LastIndexOf(" ");
                var filePath = inLine.Substring(0, spPos);
                int size = int.Parse(inLine.Substring(spPos + 1).Replace(",", ""));
                outLine = $"{filePath},{size}";
            }
            return outLine;
        }
    }
}
