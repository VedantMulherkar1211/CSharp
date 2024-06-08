using System;
namespace Mynamespace
{
    class Ass1
    {
        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);

        public void sum(int a, int b)
        {
            Console.WriteLine("({0}+{1})={2}", a, b, a + b);
        }

        public void sub()
    }
}