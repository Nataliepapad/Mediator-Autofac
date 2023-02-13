using System.Diagnostics;
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
			var sw = Stopwatch.StartNew();

			sw.Start();
			try
			{
				TimeZoneInfo targetTimeZone = TimeZoneInfo.FindSystemTimeZoneById(_timezoneId);

				DateTime targetTime = TimeZoneInfo.ConvertTime(DateTime.UtcNow, targetTimeZone);

				_iclock.PrintDateTime(targetTime);
			} catch { }

			sw.Stop();
			var ticks = sw.ElapsedTicks;
			var time = sw.ElapsedMilliseconds;
			var timeStamp = new DateTime(Stopwatch.GetTimestamp());

			Console.WriteLine(ticks);
			Console.WriteLine(time);
			Console.WriteLine(timeStamp);
		}
	}
}
