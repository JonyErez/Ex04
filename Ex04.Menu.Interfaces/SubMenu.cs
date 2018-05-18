using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ex04.Menu.Interfaces
{
	public class SubMenu : MenuItem
	{
		private List<MenuItem> m_MenuItems = new List<MenuItem>();

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
				userInput = getMenuOption(m_MenuItems.Count);
				if (userInput != 0)
				{
					m_MenuItems[(int)userInput - 1].doWhenSelected();
				}
			} while (userInput != 0);
		}

		private void printMenuOptions()
		{
			int currentOption = 1;

			Console.WriteLine(@"{0}

Menu options:", Name);
			foreach (MenuItem menuItem in m_MenuItems)
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
					string userInput = Console.ReadLine();
					selectedMenuOption = uint.Parse(userInput);
					break;
				}
				catch (FormatException ex)
				{
					Console.WriteLine(ex.Message);
				}
			}

			return selectedMenuOption;
		}
	}
}