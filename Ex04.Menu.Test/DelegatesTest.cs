using Ex04.Menu.Delegates;

namespace Ex04.Menu.Test
{
	internal class DelegatesTest
	{
		private MainMenu m_MainMenu;

		private void	createMenu()
		{
			m_MainMenu = new MainMenu("Delegates Test Menu");
			SubMenu		showDateTime		= new SubMenu("Show Date/Time");
			MenuAction	showTime			= new MenuAction("Show Time");
			MenuAction	showDate			= new MenuAction("Show Date");
			SubMenu		versionAndCapitals	= new SubMenu("Version and Capitals");
			MenuAction	countCapital		= new MenuAction("Count Capitals");
			MenuAction	showVersion			= new MenuAction("Show Vesion");
			m_MainMenu.AddMenuItem(showDateTime);
			m_MainMenu.AddMenuItem(versionAndCapitals);
			showDateTime.AddMenuItem(showTime);
			showDateTime.AddMenuItem(showDate);
			versionAndCapitals.AddMenuItem(countCapital);
			versionAndCapitals.AddMenuItem(showVersion);
			showTime.Selected		+= new TimeShower().showTime;
			showDate.Selected		+= new DateShower().showDate;
			countCapital.Selected	+= new CapitalsCounter().countCapitals;
			showVersion.Selected	+= new VersionShower().showVersion;
		}

		public	void	Show()
		{
			createMenu();
			m_MainMenu.Show();
		}
	}
}