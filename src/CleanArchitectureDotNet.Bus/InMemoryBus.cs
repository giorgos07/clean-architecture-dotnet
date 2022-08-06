using CleanArchitectureDotNet.Domain.Core.Bus;
using CleanArchitectureDotNet.Domain.Core.Commands;
using MediatR;

namespace CleanArchitectureDotNet.Bus
{
    public sealed class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        public Task SendCommand<TCommand>(TCommand command) where TCommand : Command
        {
            return _mediator.Send(command);
        }
    }
}
