using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menu.Interfaces;

namespace Ex04.Menu.Test
{
	public class DateShower : IMenuItemSelectedListener
	{
		public void DoWhenSelected(string i_OptionName)
		{
			showDate();
		}

		private void showDate()
		{
			Console.WriteLine(DateTime.Now.ToShortDateString());
		}
	}
}
