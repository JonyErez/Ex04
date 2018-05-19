using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menu.Interfaces;

namespace Ex04.Menu.Test
{
	public class CapitalsCounter : IMenuItemSelectedListener
	{
		public void DoWhenSelected()
		{
			countCapitals();
		}

		private void countCapitals()
		{
			string userInput;
			uint numberOfCapitals = 0;

			Console.WriteLine("Please enter a sentece: ");
			userInput = Console.ReadLine();
			foreach(char userInputChar in userInput)
			{
				if(char.IsUpper(userInputChar))
				{
					numberOfCapitals++;
				}
			}

			Console.WriteLine("This sentece has {0} capital letters.", numberOfCapitals);
		}
	}
}
