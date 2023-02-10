using MediatorAutofac.Ping;
using MediatR;

namespace MediatorAutofac.Handlers
{
	public class PingHandler : IRequestHandler<PingRequest, string>
	{
		public PingHandler()
		{

		}

		public Task<string> Handle(PingRequest request, CancellationToken cancellationToken)
		{
			return Task.FromResult("Ping");
		}
	}
}
