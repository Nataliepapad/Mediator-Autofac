namespace MediatorAutofac.Time.Writters
{
	public class OnlyTimeWritter : IDateWritter
	{
		public void Write(DateTime date)
		{
			Console.WriteLine(date.ToLongTimeString());
		}
	}
}
