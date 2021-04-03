using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace FileParcerTask
{
    public class FileParcer : Parcer
    {
        public override void ChangeStringInFile(string filePath, string searchString, string replaceString)
        {
            try
            {
                string currentText = string.Empty;

                using (var fileStream = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    StreamReader reader = new StreamReader(fileStream);
                    StreamWriter writer = new StreamWriter(fileStream);

                    while ((currentText = reader.ReadLine()) != null)
                    {
                        if (currentText.Contains(searchString))
                        {
                            OnCountReplaceString(currentText, replaceString);

                            currentText = currentText.Replace(searchString, replaceString);
                        }

                        writer.Write(currentText);
                    }
                }
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }

        public override void CountOccurrenceString(string filePath, string words)
        {
            using (StreamReader sr = File.OpenText(filePath))
            {
                string line = string.Empty;

                while ((line = sr.ReadLine()) != null)    
                {
                    string[] source = line.Split(' ');

                    foreach (string item in source)
                    {
                        if (item.Equals(words))
                        {
                            OnCountOccurance(item, words);
                        }
                    }
                }
            }
        }
    }
}
