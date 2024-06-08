using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBased1
{
    internal class EvenOdd
    {
        public static void Main(string[] args)
        {
            int x = 0;
            Console.Write("Enter an interger");
            x = Convert.ToInt32(Console.ReadLine());
            if(x%2==0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
            Console.ReadKey();
        }
    }
}
