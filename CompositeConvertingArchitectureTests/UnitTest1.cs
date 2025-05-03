using CompositeConvertingArchitecture.Application;
using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model;
using CompositeConvertingArchitecture.Domain.Model.Standards;
using CompositeConvertingArchitectureTests.Utils;
using Moq;

namespace CompositeConvertingArchitectureTests
{
    public class Tests
    {
        private App _app;
        private Message _message;
        private Mock<IMessageService> _messageService;

        [SetUp]
        public void Setup()
        {
            _messageService = new Mock<IMessageService>();
            _messageService.SetupAdd(r => r.MessageReceived += R_MessageReceived);
            _app = new App(_messageService.Object);

            var p1 = new Parameter1(8);
            var p2 = new Parameter2(56.7);
            var p3 = new Parameter3(0.57);
            var c2 = new Container2(new Parameter2(15), [new Parameter3(1), new Parameter3(2)], new Enum1(2));

            var container1 = new Container1(p1, p2, p3, new Enum1(2), c2);

            _message = new Message(1, 1, container1);
        }

        private void R_MessageReceived(object? sender, Message e)
        {
            throw new NotImplementedException();
        }

        [Test]
        public void SendMessage()
        {
            _app._messageService.Send(_message);

            Assert.Pass();
        }

        [Test]
        public void ReceiveMessage()
        {
            _messageService.Raise(service => service.MessageReceived += R_MessageReceived);
            //(_app.Receiver as FakeMessageService).Receive(_message.Encode());

            Assert.Pass();
        }

        [Test]
        public void EnumeratonTest()
        {
            var enumTest = new Enum1(2);

            var enumVal = enumTest.Value();

            Assert.Pass();
        }
    }
}