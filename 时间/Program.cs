using System;
using System.Timers;

namespace 事件
{
    class Program
    {
        /*
        static int counter = 0;
        static string displayString = "This string will appear one letter at a time.";
        */
        static void Main(string[] args)
        {
            Connection connection1 = new Connection();
            connection1.Name = "First connection";
            Connection connection2 = new Connection();
            connection2.Name = "Second connection.";
            Display display = new Display();
            connection1.MessageArrived += display.DisplayMessage;
            connection2.MessageArrived += display.DisplayMessage;
            connection1.Connect();
            connection2.Connect();
            System.Threading.Thread.Sleep(200);
            Console.ReadKey();







            /*
            Timer myTimer = new Timer(100);//使用一个时间段100ms来初始化Timer实例，当Start(）方法启动Timer对象时，就引发一系列事件，根据指定的时间段来引发事件。
            myTimer.Elapsed += new ElapsedEventHandler(WriteChar);//Elapsed事件要求事件处理程序必须匹配System.Timers.ElapsedEventHandler委托类型的返回类型和参数，void <methodName>(object source,ElapsedEventArgse);
            myTimer.Start();
            System.Threading.Thread.Sleep(200);
            Console.ReadKey();
            */


        }
        /*
        static void WriteChar(object source,ElapsedEventArgs e)
        {
            Console.Write(displayString[counter++ % displayString.Length]);
        }
        */
    }
}
