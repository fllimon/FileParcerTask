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

                string currentFileName = GetFileName(filePath);

                using (FileStream createFile = new FileStream(DefaultSettings.TEMPORARY_FILE, FileMode.OpenOrCreate))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {

                        StreamWriter writer = new StreamWriter(createFile);

                        while ((currentText = reader.ReadLine()) != null)
                        {
                            if (currentText.Contains(searchString))
                            {
                                OnCountReplaceString(currentText, replaceString);

                                currentText = currentText.Replace(searchString, replaceString);
                            }

                            writer.WriteLine(currentText);
                        }
                    }
                }


                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                File.Move(DefaultSettings.TEMPORARY_FILE, currentFileName);
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }

        private string GetFileName(string path)
        {
            DirectoryInfo info = new DirectoryInfo(path);

            return info.Name;
        }

        public override void CountOccurrenceString(string filePath, string words)
        {
            using (StreamReader sr = File.OpenText(filePath))
            {
                string line = string.Empty;

                while ((line = sr.ReadLine()) != null)    
                {
                    if (line.Contains(words))
                    {
                        OnCountOccurance(line, words);
                    }

                }
            }
        }
    }
}
