/*
 *Show the name and priority of default thread that 
 created in C# application.
 */

using System;
namespace System.Threading
{
    class Ass1
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(Print));
            t.Start();
        }
    }
}
