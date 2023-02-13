using System.Diagnostics;
using MediatorAutofac.PingPong.Ping;
using MediatR;

namespace MediatorAutofac.PingPong.Handlers
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
