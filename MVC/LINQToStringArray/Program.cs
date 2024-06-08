namespace LINQToStringArray;
using System;
using System.Collections;
using System.Linq;

    internal class Program
    {
    public static void Main1(string[] args)
    {
        int[] nums = new int[] { 0, 1, 2 };
        var res = from a in nums where a < 3 orderby a select a;
        foreach (int i in res)
        {
            Console.WriteLine(i);
        }
    }
}

