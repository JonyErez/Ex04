namespace Ex04.Menu.Test
{
	public static class Program
	{
		public static void Main()
		{
			InterfaceTest interfaceTest = new InterfaceTest();
			DelegatesTest delegatesTest = new DelegatesTest();
			interfaceTest.Show();
			delegatesTest.Show();
		}
	}
}