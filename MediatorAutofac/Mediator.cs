using MediatorAutofac.Ping;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorAutofac
{
    public class Mediator
    {
        private readonly IMediator _mediator;

        public Mediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        //** **//
    }
}
