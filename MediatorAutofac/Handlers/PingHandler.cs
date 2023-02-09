using MediatorAutofac.Ping;
using MediatR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
