using System;
using System.IO;

namespace DiskInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drivers = DriveInfo.GetDrives();
            foreach(DriveInfo info in drivers)
            {
                Console.WriteLine($"Name = {info.Name}");
                Console.WriteLine($"Type = {info.DriveType}");
                if (info.IsReady)
                {
                    Console.WriteLine($"Volume = {info.TotalSize}");
                    Console.WriteLine($"Free space = {info.TotalFreeSpace}");
                    Console.WriteLine($"Label = {info.VolumeLabel}");
                }
                Console.WriteLine();
            }
        }
    }
}
