using MediatorAutofac.Time.Writters;

namespace MediatorAutofac.Time.Clocks
{
	public class ClockTomorrow : IClock
	{
		private readonly IDateWritter _dateWritter;

		public ClockTomorrow(IDateWritter dateWritter)
		{
			_dateWritter = dateWritter;
		}

		public void PrintDateTime(DateTime day)
		{
			var tomorrow = day.AddDays(1);
			_dateWritter.Write(tomorrow);
		}
	}
}
