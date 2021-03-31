using System;

using FileParcerTask;

namespace FileParcerView
{
    class Program
    {
        static void Main(string[] args)
        {
            Parcer fileParcer = new FileParcer();
            Analyzer analyzer = new Analyzer(fileParcer);

            fileParcer.CountOccurrenceString(DefaultSettings.DEFAULT_FILE_PATH, "sit");

            Console.WriteLine(analyzer.CountWords);

            Console.ReadKey();
        }
    }
}
