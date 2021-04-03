using System;
using System.Diagnostics;
using FileParcerTask;

namespace FileParcerView
{
    class Program
    {
        static void Main(string[] args)
        {
            Parcer fileParcer = new FileParcer();
            Analyzer analyzer = new Analyzer(fileParcer);

            fileParcer.CountOccurrenceString(DefaultSettings.DEFAULT_FILE_PATH, "she");

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            fileParcer.ChangeStringInFile(DefaultSettings.DEFAULT_FILE_PATH, "Her parents", "parents Her");

            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;

            Console.WriteLine($"Time: {ts.TotalMilliseconds}");

            Console.WriteLine();
            Console.WriteLine($"Count text replace: {analyzer.CountTextReplace}");

            Console.WriteLine();
            Console.WriteLine($"Count substring in text: {analyzer.CountWords}");

            Console.ReadKey();
        }
    }
}
