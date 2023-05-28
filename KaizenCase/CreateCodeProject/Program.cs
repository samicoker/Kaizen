using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCodeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var codes = Codes();

            foreach (string item in codes)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }

        static List<string> Codes()
        {
            string characters = "ACDEFGHKLMNPRTXYZ234579"; // kodların içereceği karakter kümesi

            Random rnd = new Random();

            List<string> codes = new List<string>();

            for (int i = 0; i < 1000; i++)
            {
                string code = string.Empty;

                for (int j = 0; j < 8; j++)
                {
                    byte randomNumber = (byte)rnd.Next(0, (characters.Length));

                    code += characters[randomNumber];
                }

                if (codes.Count != 0 && codes.Contains(code)) 
                {
                    i--;
                    continue;
                }
                codes.Add(code);
            }
            return codes;
        }
    }
}
