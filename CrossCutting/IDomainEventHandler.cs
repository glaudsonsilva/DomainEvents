using System;

namespace CrossCutting
{
    public interface IDomainEventHandler<T>
     where T : IDomainEvent
    {
        void Handle(T domainEvent);
    }
}
