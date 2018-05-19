using System;

namespace Ex04.Menu.Delegates
{
	public class ValueOutOfRangeException : Exception
	{
		private float m_MaxValue;
		private float m_MinValue;

		public ValueOutOfRangeException(int i_MinValue, int i_MaxValue, string i_ExceptionMessage) : base(i_ExceptionMessage)
		{
			m_MaxValue = i_MaxValue;
			m_MinValue = i_MinValue;
		}

		public ValueOutOfRangeException(int i_MinValue, int i_MaxValue, string i_ExceptionMessage, Exception i_InnerException) : base(i_ExceptionMessage, i_InnerException)
		{
			m_MaxValue = i_MaxValue;
			m_MinValue = i_MinValue;
		}
	}
}
