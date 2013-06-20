using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Ionic.Utils.Zip;

namespace Updater
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("********* Updating Auxilium *********");

            Thread.Sleep(1250);

            Process[] processes = Process.GetProcessesByName("Auxilium");

            foreach (Process p in processes)
                p.Kill();

            Thread.Sleep(50); //Sleep so Windows will allow us to overwrite the files that were in use.

            string zipLocation = args[0];
            string launchFile = args[1];

            Console.WriteLine("Unpacking files...");
            using (ZipFile zip = new ZipFile(zipLocation))
            {
                foreach (ZipEntry entry in zip)
                {
                    try
                    {
                        entry.Extract(true);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
            File.Delete(zipLocation);

            Console.WriteLine("Restarting...");

            Thread.Sleep(750);

            Process.Start(launchFile);
        }
    }
}