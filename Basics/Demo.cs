using System;
class Demo
{
	public static void Main(String [] args)
	{
		if(args.Length>0)
		{
			Console.WriteLine("Welcome"+" "+args[0]);
		}
		else
		{
			Console.WriteLine("Welcome");
		}
	}
}