using System;
using System.IO;

namespace FileParcerTask
{
    public class FileParcer : Parcer
    {
        public override bool ChangeStringInFile(string filePath, string searchString, string replaceString)
        {
            throw new NotImplementedException();
        }

        public override void CountOccurrenceString(string filePath, string words)
        {
            using (StreamReader sr = File.OpenText(filePath))
            {
                string line = string.Empty;

                while ((line = sr.ReadLine()) != null)    //ToDO: Fix!!!
                {
                    OnCountOccurance(line, words);
                }
            }
        }
    }
}
