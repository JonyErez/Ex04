using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menu.Interfaces
{
	public class MainMenu : SubMenu
	{
		protected override void printReturnLine()
		{
			Console.WriteLine("0. Exit");
		}

		public MainMenu(string i_Name) : base(i_Name)
		{

		}
	}
}
