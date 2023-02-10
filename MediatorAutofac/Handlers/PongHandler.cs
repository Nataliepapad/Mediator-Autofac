using System.Diagnostics;
using MediatorAutofac.Ping;
using MediatR;

namespace MediatorAutofac.Handlers
{
	public class PongHandler : INotificationHandler<PingNotification>
	{
		public Task Handle(PingNotification notification, CancellationToken cancellationToken)
		{
			Debug.WriteLine("Pong");
			return Task.CompletedTask;
		}
	}
}
