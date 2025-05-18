using CompositeConvertingArchitecture.Application;
using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Enums;
using CompositeConvertingArchitecture.Domain.Model;
using CompositeConvertingArchitecture.Infrastructure.Coding;
using CompositeConvertingArchitectureTests.Utils;
using Moq;
using CompositeConvertingArchitecture.Infrastructure.Coding.Extensions;

namespace CompositeConvertingArchitectureTests
{
    public class Tests
    {
        private FakeMessageService _messageService;
        private Message _message;
        private Mock<IMessageService> _messageServiceMock;

        [SetUp]
        public void Setup()
        {
            //_messageServiceMock = new Mock<IMessageService>();
            //_messageServiceMock.SetupAdd(r => r.MessageReceived += R_MessageReceived);
            //_app = new App(_messageServiceMock.Object);
            _messageService = new FakeMessageService();
            var app = new App(_messageService);

            var p1 = new Parameter1(8);
            var p2 = new Parameter2(56.7);
            var p3 = new Parameter3(0.57);
            var c2 = new Container2(new Parameter2(15), [new Parameter3(1), new Parameter3(2)], Enum1.b);
            var c1 = new Container1(p1, p2, p3, Enum1.b, c2);

            _message = new Message(1, 1, c1);
        }

        [Test]
        public void SendMessage()
        {
            _messageService.Send(_message);

            Assert.Pass();
        }

        [Test]
        public void ReceiveMessage()
        {
            //_messageServiceMock.Raise(service => service.MessageReceived += R_MessageReceived);
            var wasTriggered = false;
            Message messageReceived = null;
            _messageService.MessageReceived += (s, message) =>
            {
                wasTriggered = true;
                messageReceived = message;
            };

            var codingService = new CodingService();
            _messageService.Receive(codingService.Encode(_message));

            Assert.Multiple(() =>
            {
                Assert.That(wasTriggered);
                Assert.That(messageReceived, Is.EqualTo(_message));     //value comparaison to be implemented
            });
        }

        [Test]
        public void ContainerTest()
        {
            var container1 = new Container1(
                new Parameter1(4),
                new Parameter2(6.4),
                new Parameter3(2.5),
                Enum1.d);

            var code = container1.Encode();
            code.ExtractContainer(typeof(Container1));

            Assert.Pass();
        }
    }
}