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

            // ����������� ���-������ ������� ��������� ����� �������, ��� ��� ��������� ����������� ����� �� ��� ������ ��������� ����� DequeueMessage()
            messageBrokerMock.Setup(q => q.DequeueMessage());

            // ��������� ������� ��������� ������� ����������� �������� ����������� � �����������
            var serviceUnderTests = new MessengerService(messageBrokerMock.Object);

            // Act
            // �������� ����������� ����� �� ����������� ������
            serviceUnderTests.StartService();

            // Assert
            // �� ���� ���������� ���� � ���-�������, �� ����� ����������� ��� ��������� �� �����
            // � ��������� ����� ������ �� ���-�������
            messageBrokerMock.VerifyAll();
        }
    }
}