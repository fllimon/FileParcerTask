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

            //fileParcer.CountOccurrenceString(DefaultSettings.DEFAULT_FILE_PATH, "sit");

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            fileParcer.ChangeStringInFile(DefaultSettings.DEFAULT_FILE_PATH, "'What shall I do?'", "'do I shell What?'"); //'What shall I do?'

            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;

            Console.WriteLine($"Time: {ts.TotalMilliseconds}");

            Console.WriteLine();
            Console.WriteLine($"Count text replace: {analyzer.CountTextReplace}");

            Console.ReadKey();
        }
    }
}
