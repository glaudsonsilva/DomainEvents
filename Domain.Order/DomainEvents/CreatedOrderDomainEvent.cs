using CrossCutting;

namespace Domain.Order.DomainEvents
{
    public class CreatedOrderDomainEvent : IDomainEvent
    {
        private int eventId;

        public CreatedOrderDomainEvent(int eventId)
        {
            this.eventId = eventId;
        }
    }
}