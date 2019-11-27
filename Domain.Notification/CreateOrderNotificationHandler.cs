using System.Diagnostics;
using CrossCutting;
using Domain.Order.DomainEvents;

namespace Domain.Notification
{
    public class CreateOrderNotificationHandler : IDomainEventHandler<CreatedOrderDomainEvent>
    {
        public void Handle(CreatedOrderDomainEvent domainEvent)
        {
            Debug.WriteLine("Notification: " + domainEvent);
        }
    }
}
