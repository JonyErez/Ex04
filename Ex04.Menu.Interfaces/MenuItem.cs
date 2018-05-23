namespace Ex04.Menu.Interfaces
{
	public abstract class MenuItem
	{
		private string m_Name;

		protected								MenuItem(string i_Name)
		{
			m_Name = i_Name;
		}

		protected						string	Name
		{
			get { return m_Name; }

			set { m_Name = value; }
		}

		protected internal	abstract	void	doWhenSelected();

		public				override	string	ToString()
		{
			return m_Name;
		}
	}
}