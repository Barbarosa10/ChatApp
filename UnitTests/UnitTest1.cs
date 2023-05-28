using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ChatApp;
namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        ClientSocket client;
        [TestMethod]
        public void ServerWorking()
        {
            client = ClientSocket.Instance;
            Assert.AreNotEqual(null, client);
        }
        [TestMethod]
        public void LoginWorking()
        {
            client = ClientSocket.Instance;
            LoginPacket packet = new LoginPacket
            {
                Username = "emi",
                Password = "danut"
            };
            client.SendMessage(packet);
            IPacket ack = client.ReceiveMessage();
            Assert.IsInstanceOfType(ack, typeof(LoginAckPacket), "Packet is not of LoginAck type");
            LoginAckPacket ack1 = (LoginAckPacket)ack;
            Assert.AreEqual("OK", ack1.Message, "Not logged in");
        }

        [TestMethod]
        public void RegisterWorking()
        {
            client = ClientSocket.Instance;
            RegisterPacket packet = new RegisterPacket
            {
                Username = "emi",
                Password = "danut"
            };
            client.SendMessage(packet);
            IPacket ack = client.ReceiveMessage();
            Assert.IsInstanceOfType(ack, typeof(RegisterAckPacket), "Packet is not of RegisterAck type");
            RegisterAckPacket ack1 = (RegisterAckPacket)ack;
            Assert.AreEqual("User already exists.", ack1.Message, "User already exists");
        }
    }
}
