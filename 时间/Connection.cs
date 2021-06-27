using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace 事件
{
    //public delegate void MessageHandler(string messageText);
   public class Connection
    {
        public event EventHandler<MessageArrivedEventArgs> MessageArrived;
        public string Name { get; set; }
        
        private Timer pollTimer;
        public Connection()
        {
            pollTimer = new Timer(100);
            pollTimer.Elapsed += new ElapsedEventHandler(CheckForMessage);
        }
        public void Connect() => pollTimer.Start();
        public void Disconnect() => pollTimer.Stop();
        private static Random random = new Random();
        private void CheckForMessage(object source, EventArgs e)
        {
            Console.WriteLine("Checking for new messages.");
            if ((random.Next(9) == 0)&& (MessageArrived!=null))
            {
                MessageArrivedEventArgs messageArrived = new  MessageArrivedEventArgs("Hello");
                // MessageArrived( messageArrived);
                
            }
        }

       
    }
}
