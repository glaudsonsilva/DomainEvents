namespace CrossCutting
{
    public class DomainEventsNotificationDecorator<T> :
    CommandHandler<T> where T : ICommand
    {
        private readonly CommandHandler<T> commandHandler;

        public DomainEventsNotificationDecorator(CommandHandler<T> commandHandler)
        {
            this.commandHandler = commandHandler;
        }

        public override void Handle(T command)
        {
            this.commandHandler.Handle(command);

            this.commandHandler.RaiseEvents();
        }
    }
}
