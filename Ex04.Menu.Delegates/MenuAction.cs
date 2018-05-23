using System;

namespace Ex04.Menu.Delegates
{
	public delegate void MenuOptionSelectedDelegate();

	public class MenuAction : MenuItem
	{
		public		event				MenuOptionSelectedDelegate	Selected;

		public														MenuAction(string i_Name) : base(i_Name)
		{
		}

		protected	internal override	void						doWhenSelected()
		{
			Console.Clear();
			onSelected();
			Console.WriteLine("Press enter to return to the menu.");
			Console.ReadLine();
		}

		protected	virtual				void						onSelected()
		{
			if (Selected != null)
			{
				Selected.Invoke();
			}
			else
			{
				Console.WriteLine("No methods connected to the event!");
			}
		}
	}
}