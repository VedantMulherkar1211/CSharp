using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqToObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<string> list = new List<string>()
            {
                "C# Tutorials",
                "VB.Net",
                "Learn C++",
                "MVCTutorial"
            };

            var result = from s in list where s.Contains("Tutorial") select s;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
