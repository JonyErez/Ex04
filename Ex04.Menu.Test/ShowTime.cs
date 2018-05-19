using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menu.Interfaces;

namespace Ex04.Menu.Test
{
	public class TimeShower : IMenuItemSelectedListener
	{
		public void DoWhenSelected(string i_OptionName)
		{
			showTime();
		}

		private void showTime()
		{
			Console.WriteLine(DateTime.Now.ToShortTimeString());
		}
	}
}
