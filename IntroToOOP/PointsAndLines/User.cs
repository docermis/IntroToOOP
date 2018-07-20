using IntroToOOP;
using System;

namespace PoinstAndLines
{
	class User
	{

		public readonly int HEIGHT;
		public readonly int id;

		public static int currentId;

		public Race race;

		private string username;
		private int password;

		public string Username
		{
			get
			{
				return "The username is: " + username;
			}

		}
		public int Password
		{
			set
			{
				if (value >= 4 && value <= 10)
				{
					password = value;
				}
				else
				{
					Console.WriteLine("Please use a valid password between 4-10!");
				}

			}
		}

		public User()
		{
			currentId++;
			id = currentId;
		}

		public User(string username, Race race)
		{
			currentId++;
			id = currentId;
			this.username = username;
			this.race = race;

			if (this.race == Race.Martian)
			{
				HEIGHT = 100;
			}
			else if (this.race == Race.Earthlings)
			{
				HEIGHT = 180;
			}
		}

		public void SayMyName()
		{
			Utilities.ColorfulWriteLine(this.username, ConsoleColor.DarkCyan);
		}
	}
}
