using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileListParser.Test
{
    [TestClass]
    public class FileParserTests
    {
        // Object under test
        private IFileParser mFileParser;

        [TestMethod]
        public void ConvertLine()
        {
            // Given
            var inLine = "C:\\Windows\\Microsoft.NET\\Framework\\v2.0.50727\\mscorwks.dll 5,211,808 KB Application extension 9/2/2017 2:44:50 AM 9/20/2017 12:26:30 AM 9/20/2017 12:26:30 AM";

            // When
            var outLine = mFileParser.ConvertLine(inLine);

            // Then
            Assert.AreEqual(outLine, "C:\\Windows\\Microsoft.NET\\Framework\\v2.0.50727\\mscorwks.dll,5211808");
        }

        [TestMethod]
        public void ConvertLine_WrongFormat()
        {
            // Given
            var inLine = "C:\\Windows\\Microsoft.NET\\Framework\\v2.0.50727\\mscorwks.dll 5,808 ";

            // When
            var outLine = mFileParser.ConvertLine(inLine);

            // Then
            Assert.AreEqual(outLine, "");
        }

        [TestInitialize]
        public void Initialise()
        {
            mFileParser = new FileParser();
        }
    }
}
