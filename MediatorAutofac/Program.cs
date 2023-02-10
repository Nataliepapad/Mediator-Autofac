using Autofac;
using MediatorAutofac.Time.Clocks;
using MediatorAutofac.Time.Requests;
using MediatorAutofac.Time.TimeZones;
using MediatorAutofac.Time.Writters;
using MediatR;
using MediatR.Extensions.Autofac.DependencyInjection;
using MediatR.Extensions.Autofac.DependencyInjection.Builder;

namespace MediatorAutofac
{
	internal class Program
	{
		static async Task Main(string[] _)
		{
			var builder = new ContainerBuilder();

			var mediatorConfiguration = MediatRConfigurationBuilder
				.Create(typeof(Program).Assembly)
				.WithAllOpenGenericHandlerTypesRegistered()
				.WithRegistrationScope(RegistrationScope.Transient)
				.Build();

			builder.RegisterMediatR(mediatorConfiguration);

			//builder.RegisterType<ClockToday>().AsImplementedInterfaces().SingleInstance();
			//builder.RegisterType<ShortDateWritter>().AsImplementedInterfaces().SingleInstance();

			var dateWritterGR = new FullDateWritter();
			var clockGR = new ClockToday(dateWritterGR);
			var timeZoneGR = new TimeZoneWritter(clockGR, "W. Europe Standard Time");
			builder.RegisterInstance(timeZoneGR).Keyed<ITimeZoneWritter>("GR");

			var dateWritterUS = new ShortDateWritter();
			var clockUS = new ClockTomorrow(dateWritterUS);
			var timeZoneUS = new TimeZoneWritter(clockUS, "W. Europe Standard Time");
			builder.RegisterInstance(timeZoneUS).Keyed<ITimeZoneWritter>("US");

			var dateWritterIS = new OnlyTimeWritter();
			var clockIS = new ClockToday(dateWritterIS);
			var timeZoneIS = new TimeZoneWritter(clockIS, "W. Europe Standard Time");
			builder.RegisterInstance(timeZoneIS).Keyed<ITimeZoneWritter>("IS");

			var container = builder.Build();

			var mediator = container.Resolve<IMediator>();

			//var response = await mediator.Send(new PingRequest());
			//response = await mediator.Send(new PingRequest());

			var response = await mediator.Send(new ClockRequest("GR"));
			response = await mediator.Send(new ClockRequest("US"));
			response = await mediator.Send(new ClockRequest("IS"));
		}
	}
}