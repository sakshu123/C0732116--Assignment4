using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections; 

namespace week14
{
    class Program
    {
       

        static void Main(string[] args)
        {
            int Lines = File.ReadAllLines(@"U:\\Users\\732116\\beowulf.txt").Length;
            Console.WriteLine("The number of lines in this essay are: " + Lines.ToString());

        }

    }
}
