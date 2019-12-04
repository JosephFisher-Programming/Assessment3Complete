using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextTest
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter("Dialogue.txt");
            writer.WriteLine("Testing123");
            writer.Close();
            StreamReader reader = new StreamReader("Dialogue.txt");
            //string line = reader.ReadLine();
            Console.WriteLine(reader.ReadLine());
            reader.Close();
            Console.ReadLine();
        }
    }
}
