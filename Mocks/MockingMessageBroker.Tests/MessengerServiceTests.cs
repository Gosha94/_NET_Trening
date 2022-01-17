using Moq;
using NUnit.Framework;
using MockingMessageBroker.Contracts;

namespace MockingMessageBroker.Tests
{
    [TestFixture]
    public class MessengerServiceTests
    {

        [Test]
        public void MessageShouldBeDequeuedFromMessageBrokerWhenServiceStart()
        {
            // Arrange
            var messageBrokerMock = new Mock<IMessageBroker>();

            // Настраиваем Мок-Объект Брокера Сообщений таким образом, что для успешного прохождения теста на нем должен вызваться метод DequeueMessage()
            messageBrokerMock.Setup(q => q.DequeueMessage());

            // Применяем принцип внедрения заранее настроенной тестовой зависимости в конструктор
            var serviceUnderTests = new MessengerService(messageBrokerMock.Object);

            // Act
            // Вызываем проверяемый метод на тестируемом классе
            serviceUnderTests.StartService();

            // Assert
            // За счет ссылочного типа у Мок-Объекта, мы можем отслеживать его состояние из теста
            // и проверить вызов метода на Мок-Объекте
            messageBrokerMock.VerifyAll();
        }
    }
}