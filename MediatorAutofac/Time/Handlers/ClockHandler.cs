using Autofac.Features.Indexed;
using MediatorAutofac.Time.Requests;
using MediatorAutofac.Time.TimeZones;
using MediatR;

namespace MediatorAutofac.Time.Handlers
{

	// We implement IRequestHandler in order to handle the command/queries (in this case "ClockRequest"), followed by the output
	public class ClockHandler : IRequestHandler<ClockRequest, Unit>
	{
		private readonly IIndex<string, ITimeZoneWritter> _timeZones;

		public ClockHandler(IIndex<string, ITimeZoneWritter> timeZones)
		{
			_timeZones = timeZones;
		}

		// In the Handle we pass our request 
		// The cancellation token is because everything in the MediatR is async
		public Task<Unit> Handle(ClockRequest clockRequest, CancellationToken ct)
		{
			if (_timeZones.TryGetValue(clockRequest.Country, out ITimeZoneWritter timeZones))
				timeZones.PrintTimeZone(clockRequest.Country);

			return Unit.Task;
		}
	}
}
