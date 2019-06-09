using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2002807_Maeda_TextEditor
{
    public class ReadWrite
    {
        private string filePath;

        public ReadWrite(string path)
        {
            filePath = path;
        }

        public string ReadFile()
        {
            string fileContent = "";
            using (var reader = new StreamReader(filePath))
            {
                fileContent = reader.ReadToEnd();
            }

            return fileContent;
        }

        public void WriteToFile(string[] FileContent)
        {
            File.WriteAllLines(filePath, FileContent);
        }
    }
}
