using System;
using Ex04.Menu.Interfaces;

namespace Ex04.Menu.Test
{
	public class VersionShower : IMenuItemSelectedListener
	{
		public		void	DoWhenSelected()
		{
			showVersion();
		}

		internal	void	showVersion()
		{
			Console.WriteLine("Version: 18.2.4.0");
		}
	}
}