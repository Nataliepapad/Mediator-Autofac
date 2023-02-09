using Autofac;
using MediatorAutofac.Ping;
using MediatorAutofac.Time.Clocks;
using MediatorAutofac.Time.Handlers;
using MediatorAutofac.Time.Writters;
using MediatR;
using MediatR.Extensions.Autofac.DependencyInjection;
using MediatR.Extensions.Autofac.DependencyInjection.Builder;

namespace MediatorAutofac
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = new ContainerBuilder();

            var mediatorConfiguration = MediatRConfigurationBuilder
                .Create(typeof(Program).Assembly)
                .WithAllOpenGenericHandlerTypesRegistered()
                .WithRegistrationScope(RegistrationScope.Transient)
                .Build();

            builder.RegisterMediatR(mediatorConfiguration);

            var container = builder.Build();

            var mediator = container.Resolve<IMediator>();

            var response = await mediator.Send(new PingRequest());
             response = await mediator.Send(new PingRequest());


            response = await mediator.Send(new ClockRequest());
        }
    }
}