using PoinstAndLines;
using System;

class EntryPoint
{
	static void Main()
	{
		Point point = new Point(5, 3);

		Point pointTwo = new Point();

		pointTwo.X = 5;	

		Console.WriteLine(point.X);
		Console.WriteLine(point.Y);

		Console.WriteLine("Press enter to close...");
		Console.ReadLine();
	}
}

