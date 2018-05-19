using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menu.Interfaces;

namespace Ex04.Menu.Test
{
	public class InterfaceTest
	{
		private MainMenu m_MainMenu;

		private void createMenu()
		{
			m_MainMenu = new MainMenu("Interface Test Menu");

			SubMenu showDateTime = new SubMenu("Show Date/Time");
			MenuAction showTime = new MenuAction("Show Time", new TimeShower());
			MenuAction showDate = new MenuAction("Show Date", new DateShower());
			SubMenu versionAndCapitals = new SubMenu("Version and Capitals");
			MenuAction countCapital = new MenuAction("Count Capitals", new CapitalsCounter());
			MenuAction showVersion = new MenuAction("Show Vesion", new VersionShower());

			m_MainMenu.AddMenuItem(showDateTime);
			m_MainMenu.AddMenuItem(versionAndCapitals);
			showDateTime.AddMenuItem(showTime);
			showDateTime.AddMenuItem(showDate);
			versionAndCapitals.AddMenuItem(countCapital);
			versionAndCapitals.AddMenuItem(showVersion);
		}

		public void Show()
		{
			createMenu();
			m_MainMenu.Show();
		}
	}
}
