using IntroToOOP;
using PoinstAndLines;
using System;

class EntryPoint
{
	static void Main()
	{
		User user = new User("Vachev", Race.Earthlings);
		User secondUser = new User();

		user.Password = 8;

		Utilities.ColorfulWriteLine(user.Username, ConsoleColor.Blue);
		user.SayMyName();

		Console.WriteLine(user.Username);
		Console.WriteLine(User.currentId);


		Console.WriteLine("Press enter to close...");
		Console.ReadLine();
	}
}

