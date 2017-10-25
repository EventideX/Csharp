using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] a = new int[2, 2] { { 1, 1 }, { 2, 2 } };
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}
