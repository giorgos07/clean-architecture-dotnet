using CleanArchitectureDotNet.Domain.Core.Events;

namespace CleanArchitectureDotNet.Domain.Core.Commands
{
    public class Command : Message
    {
        protected Command()
        {
            Timestamp = DateTimeOffset.UtcNow;
        }

        public DateTimeOffset Timestamp { get; protected set; }
    }
}
