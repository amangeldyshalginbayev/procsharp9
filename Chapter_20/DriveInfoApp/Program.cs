using System;
using System.IO;

namespace DriveInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FunWithDriveInfo();
            Console.ReadLine();
        }

        private static void FunWithDriveInfo()
        {
            DriveInfo[] myDrives = DriveInfo.GetDrives();
            foreach (var d in myDrives)
            {
                Console.WriteLine($"Name: {d.Name}");
                Console.WriteLine($"Type: {d.DriveType}");

                if (d.IsReady) // is drive mounted?
                {
                    Console.WriteLine($"Free space: {d.TotalFreeSpace}");
                    Console.WriteLine($"Format: {d.DriveFormat}");
                    Console.WriteLine($"Label: {d.VolumeLabel}");
                }

                Console.WriteLine();
            }
        }
    }
}