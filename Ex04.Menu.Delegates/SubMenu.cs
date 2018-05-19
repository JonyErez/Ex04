using System;
using System.Collections.Generic;

namespace Ex04.Menu.Delegates
{
	public class SubMenu : MenuItem
	{
		private readonly List<MenuItem> r_MenuItems = new List<MenuItem>();

		public SubMenu(string i_Name) : base(i_Name)
		{
		}

		protected internal override void doWhenSelected()
		{
			Show();
		}

		public void Show()
		{
			uint userInput;

			do
			{
				Console.Clear();
				printMenuOptions();
				userInput = getMenuOption(r_MenuItems.Count);
				if (userInput != 0)
				{
					r_MenuItems[(int)userInput - 1].doWhenSelected();
				}
			} while (userInput != 0);
		}

		private void printMenuOptions()
		{
			int currentOption = 1;

			Console.WriteLine(@"{0}

Menu options:", Name);
			foreach (MenuItem menuItem in r_MenuItems)
			{
				Console.WriteLine("{0}. {1}", currentOption, menuItem.ToString());
				currentOption++;
			}

			printReturnLine();
		}

		protected virtual void printReturnLine()
		{
			Console.WriteLine("0. Back");
		}

		private uint getMenuOption(int i_MaxAvailableInput)
		{
			uint selectedMenuOption;

			while (true)
			{
				try
				{
					Console.Write("Please select an option from the menu: ");
					string userInput = Console.ReadLine();
					selectedMenuOption = validateInput(userInput, i_MaxAvailableInput);
					break;
				}
				catch (FormatException)
				{
					Console.WriteLine("Invalid input format. Please enter digits only.");
				}
				catch (ValueOutOfRangeException ex)
				{
					Console.WriteLine(ex.Message);
				}
			}

			return selectedMenuOption;
		}

		private uint validateInput(string i_UserInput, int i_MaxAvailableInput)
		{
			uint selectedMenuOption;
			try
			{
				selectedMenuOption = uint.Parse(i_UserInput);
			}
			catch (OverflowException ex)
			{
				throw new ValueOutOfRangeException(0, i_MaxAvailableInput, string.Format(@"The value you entered is out of range. Please enter a valid input between {0}-{1}.", 0, i_MaxAvailableInput), ex);
			}
			if (selectedMenuOption > i_MaxAvailableInput)
			{
				throw new ValueOutOfRangeException(0, i_MaxAvailableInput, string.Format(@"The value you entered is out of range. Please enter a valid input between {0}-{1}.", 0, i_MaxAvailableInput));
			}

			return selectedMenuOption;
		}

		public void AddMenuItem(MenuItem i_MenuItemToAdd)
		{
			r_MenuItems.Add(i_MenuItemToAdd);
		}
	}
}