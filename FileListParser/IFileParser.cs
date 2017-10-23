namespace FileListParser
{
    public interface IFileParser
    {
        string ConvertLine(string inLine);
        void ParseFile(string inPath, string outPath);
    }
}