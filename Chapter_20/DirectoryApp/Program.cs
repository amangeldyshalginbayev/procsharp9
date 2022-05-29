using System;
using System.IO;

namespace DirectoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Directory(Info) *****\n");
            //ShowMacOsDirectoryInfo();
            //DisplayImageFiles();
            //ModifyAppDirectory();
            FunWithDirectoryType();
        }

        private static void ShowMacOsDirectoryInfo()
        {
            var directorySeparator = Path.DirectorySeparatorChar;
            DirectoryInfo dir = new DirectoryInfo($@"{directorySeparator}Users{directorySeparator}aman{directorySeparator}Desktop{directorySeparator}files");
            Console.WriteLine("***** Directory info *****");
            Console.WriteLine($"Full name: {dir.FullName}");
            Console.WriteLine($"Name: {dir.Name}");
            Console.WriteLine($"Parent: {dir.Parent}");
            Console.WriteLine($"Creation: {dir.CreationTime}");
            Console.WriteLine($"Attributes: {dir.Attributes}");
            Console.WriteLine($"Root: {dir.Root}");
            Console.WriteLine("***************************\n");
        }

        private static void DisplayImageFiles()
        {
            var directorySeparator = Path.DirectorySeparatorChar;
            DirectoryInfo dir = new DirectoryInfo($@"{directorySeparator}Users{directorySeparator}aman{directorySeparator}Desktop{directorySeparator}files");

            FileInfo[] imagesFiles = dir.GetFiles("*.jpg",SearchOption.AllDirectories);

            Console.WriteLine($"Found: {imagesFiles.Length} *.jpg files.");

            foreach (var f in imagesFiles)
            {
                Console.WriteLine("**************************");
                Console.WriteLine($"File name: {f.Name}");
                Console.WriteLine($"File size: {f.Length}");
                Console.WriteLine($"Creation: {f.CreationTime}");
                Console.WriteLine($"Attributes: {f.Attributes}");
                Console.WriteLine("*************************\n");
            }
        }

        private static void ModifyAppDirectory()
        {
            DirectoryInfo dir = new DirectoryInfo(".");// current directory
            dir.CreateSubdirectory("MyFolder");
            DirectoryInfo myDataFolder = dir.CreateSubdirectory($@"MyFolder2{Path.DirectorySeparatorChar}Data");
            Console.WriteLine($"New folder is: {myDataFolder}");
        }

        private static void FunWithDirectoryType()
        {
            string[] drives = Directory.GetLogicalDrives();
            Console.WriteLine("Here are your drives: ");
            foreach (var d in drives)
            {
                Console.WriteLine($"--> {d}");
            }

            Console.WriteLine($"Current drive is: {Path.GetPathRoot(Environment.CurrentDirectory)}");

            Console.WriteLine("Press enter to delete directories");
            Console.ReadLine();
            try
            {
                Directory.Delete("MyFolder");
                Directory.Delete("MyFolder2",true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}