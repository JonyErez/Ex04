using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menu.Delegates;

namespace Ex04.Menu.Test
{
	class DelegatesTest
	{
		private MainMenu m_MainMenu;

		private void createMenu()
		{
			m_MainMenu = new MainMenu("Delegates Test Menu");

			SubMenu    showDateTime       = new SubMenu("Show Date/Time");
			MenuAction showTime           = new MenuAction("Show Time");
			MenuAction showDate           = new MenuAction("Show Date");
			SubMenu    versionAndCapitals = new SubMenu("Version and Capitals");
			MenuAction countCapital       = new MenuAction("Count Capitals");
			MenuAction showVersion        = new MenuAction("Show Vesion");

			m_MainMenu.AddMenuItem(showDateTime);
			m_MainMenu.AddMenuItem(versionAndCapitals);
			showDateTime.AddMenuItem(showTime);
			showDateTime.AddMenuItem(showDate);
			versionAndCapitals.AddMenuItem(countCapital);
			versionAndCapitals.AddMenuItem(showVersion);
			showTime.Selected += this.showTime;
			showDate.Selected += this.showDate;
			countCapital.Selected += this.countCapitals;
			showVersion.Selected += this.showVersion;
		}

		public void Show()
		{
			createMenu();
			m_MainMenu.Show();
		}

		private void showDate()
		{
			Console.WriteLine(DateTime.Now.ToShortDateString());
		}

		private void showTime()
		{
			Console.WriteLine(DateTime.Now.ToShortTimeString());
		}

		private void showVersion()
		{
			Console.WriteLine("Version: 18.2.4.0");
		}

		private void countCapitals()
		{
			string userInput;
			uint   numberOfCapitals = 0;

			Console.WriteLine("Please enter a sentece: ");
			userInput = Console.ReadLine();
			foreach (char userInputChar in userInput)
			{
				if (char.IsUpper(userInputChar))
				{
					numberOfCapitals++;
				}
			}

			Console.WriteLine("This sentece has {0} capital letters.", numberOfCapitals);
		}
	}
}