using System;
using CrossCutting;
using Domain.Order.Commands;
using Domain.Order.Handlers;

namespace ConsoleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var handler = new DomainEventsNotificationDecorator<CreateOrderCommand>(new CreateOrderCommandHandler());

            handler.Handle(new CreateOrderCommand());
        }
    }
}
