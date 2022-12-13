using System;
using System.IO;

namespace OnePixel
{
    class Program
    {
        static void Main()
        {
            Console.Write("Identifier: ");
            string identifier = Console.ReadLine();
            identifier = identifier.Replace(' ','-');
            string full_name = $"{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Hour}-{DateTime.Now.Minute}-{identifier}";
            string file = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + full_name + ".html";
            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.Write($"<!doctype html><img src=\"https://www.kellphy.com/assets/images/opet.png?{full_name}\" alt=\"img\" />");
            }
            Console.WriteLine("Completed!");
            Console.ReadLine();
            Main();
        }
    }
}
