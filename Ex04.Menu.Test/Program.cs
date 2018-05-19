using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menu.Test
{
	public class Program
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
