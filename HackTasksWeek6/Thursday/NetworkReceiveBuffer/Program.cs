using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkReceiveBuffer
{
    //this page consists of all three classes needed for the task
    public delegate void RemadeEventHandler(object sender, EventMessageArgs e);

    class Program
    {
        static void Main(string[] args)
        {
            string message = "code my message";
            ReceiveBuffer buffer = new ReceiveBuffer();
            buffer.MessageReceived += Buffer_MessageReceived;
            buffer.ByteRecieved(PacketGenerator.ConvertToByteArray(message));
        }

        private static void Buffer_MessageReceived(object sender, EventMessageArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
    //packete generator class
    public static class PacketGenerator
    {
        public static byte[] ConvertToByteArray(string message)
        {
            return Encoding.UTF8.GetBytes(message);
        }
    }
    //creating the buffer
    public class ReceiveBuffer
    {
        public event RemadeEventHandler MessageReceived;
        private string message;

        public void ByteRecieved(byte[] data)
        {
            var message = this.message;
            this.message = Encoding.UTF8.GetString(data);
            if(this.message!=null)
            {
                this.MessageReceived(this, new EventMessageArgs(this.message));
            }

        }
    }

    //creating event message definition
    public class EventMessageArgs : EventArgs
    {
        private string message;

        public EventMessageArgs(string message)
        {
            this.message = message;
        }

        public string Message
        {
            get { return message; }
        }
    }
}
