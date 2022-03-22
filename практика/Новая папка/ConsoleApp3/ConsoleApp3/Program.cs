using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ello world!");
            string[] marks = { "5,4,5,5" };
            int[] mass = { 5, 3, 4, 2 };
            Console.WriteLine("5" + "5");
            string mark = "5";
            int m = Convert.ToInt32(mark);
            Console.WriteLine(m + m);
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(marks[i]);
                int[] 1 = 
            }
            double res = Utils.MinAVG(marks);
            Console.WriteLine("Средний балл +" + res);
        }
    }
}
