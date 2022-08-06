using CleanArchitectureDotNet.Domain.Core.Commands;

namespace CleanArchitectureDotNet.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<TCommand>(TCommand command) where TCommand : Command;
    }
}
