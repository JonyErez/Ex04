using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menu.Interfaces
{
	internal class MenuAction : MenuItem
	{
		private IMenuItemSelectedListener m_WhenSelectedHandler;

		public MenuAction(string i_Name, IMenuItemSelectedListener i_Listener) : base(i_Name)
		{
			m_WhenSelectedHandler = i_Listener;
		}

		public IMenuItemSelectedListener MenuItemSelectedListener
		{
			get
			{
				return m_WhenSelectedHandler;
			}

			set
			{
				m_WhenSelectedHandler = value;
			}
		}

		protected internal override void doWhenSelected()
		{
			Console.Clear();
			notifySelectedListener();
		}

		private void notifySelectedListener()
		{
			m_WhenSelectedHandler.DoWhenSelected(Name);
		}
	}
}