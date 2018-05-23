using System;
using Ex04.Menu.Interfaces;

namespace Ex04.Menu.Test
{
	public class DateShower : IMenuItemSelectedListener
	{
		public		void	DoWhenSelected()
		{
			showDate();
		}

		internal	void	showDate()
		{
			Console.WriteLine(DateTime.Now.ToShortDateString());
		}
	}
}