﻿namespace MediatorAutofac.Time.Writters
{
	public class ShortDateWritter : IDateWritter
	{
		public void Write(DateTime date)
		{
			Console.WriteLine(date.ToString());
		}
	}
}
