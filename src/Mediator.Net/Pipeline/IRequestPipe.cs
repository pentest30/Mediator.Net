﻿using System.Threading.Tasks;
using Mediator.Net.Context;
using Mediator.Net.Contracts;

namespace Mediator.Net.Pipeline
{
    public interface IRequestPipe<TContext> : IPipe<TContext>
        where TContext : IContext<IRequest>
    {
        new Task<object> Connect(TContext context);
    }
}
