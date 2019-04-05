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
        ArrayList Beowulf;

        static void Main(string[] args)
        {

            Program p = new Program();
            p.Beowulf = new ArrayList();
            
        }

        public void Run ()
        {
            this.ReadTextFiles();
        }

        public void ReadTextFiles()
        {
            using (StreamReader file = new StreamReader("U:\\Users\\732116\\beowulf"))
            {
                int counter = 0;
                String ln;

                while ((ln = file.ReadLine()) ! = null){
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                }

                file.Close();
                Console.WriteLine($"File has {counter} lines.");

            }
        }

        public int FindNumberOfBlankSpaces(String line)
        {
            int countletters = 0;
            int countspaces = 0;

            foreach (char c in line)
            {
                if (char.IsLetter(C))
                {
                    countletters++;
                }
                if (char.IsWhiteSpace(c))
                {
                    countspaces++;
                }

                return countspaces;

            }
        }


    }
}
