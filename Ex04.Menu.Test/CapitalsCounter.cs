using System;
using Ex04.Menu.Interfaces;

namespace Ex04.Menu.Test
{
	public class CapitalsCounter : IMenuItemSelectedListener
	{
		public		void	DoWhenSelected()
		{
			countCapitals();
		}

		internal	void	countCapitals()
		{
			uint numberOfCapitals = 0;
			Console.WriteLine("Please enter a sentece: ");
			string userInput = Console.ReadLine();
			foreach (char userInputChar in userInput)
			{
				if (char.IsUpper(userInputChar))
				{
					numberOfCapitals++;
				}
			}

			Console.WriteLine("This sentece has {0} capital letters.", numberOfCapitals);
		}
	}
}