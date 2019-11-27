using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Diagnostics;
using System.Text;

namespace CrossCutting
{
    public class MessageBus
    {
        public static void Receiver()
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            var connection = factory.CreateConnection();
            var channel = connection.CreateModel();

            var exchangeName = "application.domainevents";
            var queueName = "domainevents";

            channel.ExchangeDeclare(exchange: exchangeName, type: ExchangeType.Fanout);

            channel.QueueDeclare(queueName);

            channel.QueueBind(queue: queueName, exchange: exchangeName, routingKey: "");

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body;
                var message = Encoding.UTF8.GetString(body);
                Debug.WriteLine(" [x] {0}", message);
            };

            channel.BasicConsume(queue: queueName,
                                 autoAck: true,
                                 consumer: consumer);
        }
    }
}
