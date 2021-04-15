using System;
using System.IO;

namespace PoemaDetalle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var poem = File.ReadAllLines("crunch.txt");
            // Console.WriteLine("Hello World!");
            // Console.WriteLine(poem[0]);
            richTextBox1.Text = poem;
        }
    }
}
