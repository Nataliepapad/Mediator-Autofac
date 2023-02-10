using MediatorAutofac.Time.Writters;

namespace MediatorAutofac.Time.Clocks

{
	public class ClockToday : IClock
	{
		private readonly IDateWritter _dateWritter;

		public ClockToday(IDateWritter dateWritter)
		{
			_dateWritter = dateWritter;
		}

		public void PrintDateTime(DateTime day)
		{
			_dateWritter.Write(day);
		}
	}
}
