using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int chanceToSnap = rand.Next(1, 100);
            int snapNumOne = 0;
            int snapNumTwo = 0;
            int snapAns = 0;
            int snapFunction = 0;
            string operation = "";
            string question = "";
            if (chanceToSnap > 70) {
                snapNumOne = rand.Next(1, 100);
                snapNumTwo = rand.Next(1, 100);
                snapFunction = rand.Next(1, 3);
                switch (snapFunction) {
                    case 1:
                        snapAns = snapNumOne + snapNumTwo;
                        operation = "+";
                        break;
                    case 2:
                        snapAns = snapNumOne * snapNumTwo;
                        operation = "*";
                        break;
                    case 3:
                        snapAns = snapNumOne / snapNumTwo;
                        operation = "/";
                        break;
                }
                question = snapNumOne + operation + snapNumTwo;
                Console.WriteLine(question);
            }
            Console.ReadLine();
        }
    }
}
