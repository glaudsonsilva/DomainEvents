
using CrossCutting;
using Domain.Order.Commands;
using Domain.Order.DomainEvents;

namespace Domain.Order.Handlers
{
    public class CreateOrderCommandHandler : CommandHandler<CreateOrderCommand>
    {
        private CreateOrderCommandHandler()
        {
        }

        public static CommandHandler<CreateOrderCommand> instanciate()
        {
            return new DomainEventsNotificationDecorator<CreateOrderCommand>(new CreateOrderCommandHandler());
        }

        public override void Handle(CreateOrderCommand command)
        {

            // verify command

            // instanciate entity

            // business validation

            // persist order
            var eventId = 23321;

            // Domain event
            this.AddDomainEvent(new CreatedOrderDomainEvent(eventId));
        }
    }
}