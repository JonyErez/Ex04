using System;

namespace Ex04.Menu.Delegates
{
	public class MainMenu : SubMenu
	{
		protected override void	printReturnLine()
		{
			Console.WriteLine("0. Exit");
		}

		public					MainMenu(string i_Name) : base(i_Name)
		{
		}
	}
}