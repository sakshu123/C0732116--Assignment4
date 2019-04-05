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
            p.ReadTextFiles();

            Console.ReadLine();
        }
        public void Run()
        {
            this.ReadTextFiles();
        }

        public void ReadTextFiles()
        {
            using (StreamReader file = new StreamReader("U:\\Users\\732116\\Beowulf.txt"))
            {

   


                int words = 0;
                string delim = " ,.";
                string[] fields = null;
                string line = null;

                while (!file.EndOfStream)
                {
                    line = file.ReadLine();//each time you read a line you should split it into the words
                    line.Trim();
                    fields = line.Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    words += fields.Length; //and just add how many of them there is
                }


               
                Console.WriteLine("The word count is {0}", words);


                file.Close();

            }
        }
        public int FindNumberOfBlankSpaces(string line)
        {
            int countletters = 0;
            int countSpaces = 0;

            foreach (char c in line)
            {
                if (char.IsLetter(c)) { countletters++; }

                if (char.IsWhiteSpace(c)) { countletters++; }
            }
            return countSpaces;

        }

    }
}