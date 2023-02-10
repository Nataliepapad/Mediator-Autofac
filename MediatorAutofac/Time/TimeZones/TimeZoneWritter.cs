using System.Globalization;
using MediatorAutofac.Time.Clocks;
using NodaTime.TimeZones;

namespace MediatorAutofac.Time.TimeZones
{
	public class TimeZoneWritter : ITimeZoneWritter
	{
		private readonly IClock _iclock;
		private readonly string _timezoneId;

		public TimeZoneWritter(IClock clock, string timezoneId)
		{
			_iclock = clock;
			_timezoneId = timezoneId;
		}

		public void PrintTimeZone(string countryCode)
		{
			TimeZoneInfo targetTimeZone = TimeZoneInfo.FindSystemTimeZoneById(_timezoneId);

			DateTime targetTime = TimeZoneInfo.ConvertTime(DateTime.UtcNow, targetTimeZone);

			_iclock.PrintDateTime(targetTime);
		}
	}
}
