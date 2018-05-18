using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menu.Interfaces
{
	public interface IMenuItemSelectedListener
	{
		void DoWhenSelected(string i_OptionName);
	}
}