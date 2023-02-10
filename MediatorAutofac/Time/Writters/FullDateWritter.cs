namespace MediatorAutofac.Time.Writters
{
	public class FullDateWritter : IDateWritter
	{
		public void Write(DateTime date)
		{
			Console.WriteLine(date.ToLongDateString());
		}
	}
}
