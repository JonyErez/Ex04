using System;
using Ex04.Menu.Interfaces;

namespace Ex04.Menu.Test
{
	public class TimeShower : IMenuItemSelectedListener
	{
		public		void	DoWhenSelected()
		{
			showTime();
		}

		internal	void	showTime()
		{
			Console.WriteLine(DateTime.Now.ToShortTimeString());
		}
	}
}