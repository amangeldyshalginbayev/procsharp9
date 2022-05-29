using System;
using System.IO;

namespace MyDirectoryWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Amazing File Watcher App *****\n");

            FileSystemWatcher watcher = new FileSystemWatcher();

            var path = @"/Users/aman/Desktop/files/repositories/procsharp9/Chapter_20/watched_directory/";

            try
            {
                watcher.Path = path;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName |
                                   NotifyFilters.DirectoryName;

            watcher.Filter = "*.txt";

            // Add event handlers
            // Specify whats done when file created, changed or deleted
            watcher.Changed += (s, e) => Console.WriteLine($"File: {e.FullPath} -- {e.ChangeType}");
            watcher.Created += (s, e) => Console.WriteLine($"File: {e.FullPath} -- {e.ChangeType}");
            watcher.Deleted += (s, e) => Console.WriteLine($"File: {e.FullPath} -- {e.ChangeType}");

            watcher.Renamed += (s, e) => Console.WriteLine($"File: {e.OldFullPath} renamed to {e.FullPath}");

            watcher.EnableRaisingEvents = true;
            // while (Console.Read() != 'q')
            // {
            //     Console.WriteLine(@"Press 'q' to quit app.");
            //
            //     var filePath = path + "TestFile.txt";
            //     // raise some event to check
            //     using (var sw = File.CreateText(filePath))
            //     {
            //         sw.Write("Some text to write");
            //     }
            //
            //     var moveToPath = path + "TestFile2.txt";
            //     File.Move(filePath, moveToPath);
            //     File.Delete(moveToPath);
            // }

            Console.ReadLine();
        }
    }
}