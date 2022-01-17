using MockingMessageBroker.Contracts;

namespace MockingMessageBroker
{
    public class MessengerService
    {
        private readonly IMessageBroker _messageBroker;

        public MessengerService(IMessageBroker messageBroker)
        {
            _messageBroker = messageBroker;
        }

        public void StartService()
        {
            _messageBroker.DequeueMessage();
        }

    }
}