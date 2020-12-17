using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SalesTaxCalculator
{
    public class SalesTaxCalculator
    {
        public static void Main()
        {
            string path = File.ReadAllLines(@"Settings.txt")[0];
            var txtFiles = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            foreach (string currentFile in txtFiles)
            {
                string[] lines = File.ReadAllLines(currentFile);
                InputProcessor.ProcessInput(lines);
                Console.WriteLine("--------------------------------------------------");
            }
            Console.ReadLine();
        }
    }
}