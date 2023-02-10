using MediatR;

namespace MediatorAutofac.Time.Requests
{
	// We implement IRequest with the type we want to return
	public class ClockRequest : IRequest<Unit>
	{
		public string Country { get; }

		public ClockRequest(string country)
		{
			Country = country;
		}
	}
}
