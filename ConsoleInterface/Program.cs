using System;
using System.Diagnostics;
using System.Text;
using CrossCutting;
using Domain.Order.Commands;
using Domain.Order.Handlers;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace ConsoleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageBus.Receiver();

            var handler = new DomainEventsNotificationDecorator<CreateOrderCommand>(new CreateOrderCommandHandler());

            handler.Handle(new CreateOrderCommand());

            Console.ReadKey();
        }
    }
}
