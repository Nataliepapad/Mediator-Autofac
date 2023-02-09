using MediatorAutofac.Ping;
using MediatorAutofac.Time.Clocks;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorAutofac.Time.Handlers
{
    public class ClockHandler : IRequestHandler<ClockRequest, string>
    {

        public ClockHandler() { }

        public Task<string> Handle(ClockRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult("Testing clock");
        }
    }
}
