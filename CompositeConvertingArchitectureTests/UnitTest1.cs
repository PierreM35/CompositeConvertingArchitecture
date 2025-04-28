using CompositeConvertingArchitecture;
using CompositeConvertingArchitecture.Application;
using CompositeConvertingArchitecture.Domain.Model;
using CompositeConvertingArchitecture.Infrastructure;
using CompositeConvertingArchitecture.Standards.V1;

namespace CompositeConvertingArchitectureTests
{
    public class Tests
    {
        private App _app;
        private Message _message;

        [SetUp]
        public void Setup()
        {
            _app = new App(new Sender(), new Receiver());

            var p1 = new Parameter1(8);
            var p2 = new Parameter2(56.7);
            var p3 = new Parameter3(0.57);
            var c2 = new Container2(new Parameter2(15), [new Parameter3(1), new Parameter3(2)]);

            var container1 = StandardSource.Standards[0].Containers.Container1.Invoke(p1, p2, p3, c2);

            _message = new Message(1, container1);
        }

        [Test]
        public void SendMessage()
        {
            _app.Sender.Send(_message);

            Assert.Pass();
        }

        [Test]
        public void ReceiveMessage()
        {
            (_app.Receiver as Receiver).Receive(_message.Encode());

            Assert.Pass();
        }

        [Test]
        public void EnumeratonTest()
        {
            var enumTest = new SomeEnum(2, 5);

            var enumVal = enumTest.Value();

            Assert.Pass();
        }
    }
}