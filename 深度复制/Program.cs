using System;

namespace 深度复制
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Cloner 
    {
        public int val;
        public Cloner(int newVal)
        {
            val = newVal;
        }
        public object CetCopy() => MemberwiseClone();
    }
    public class Content
    {
        public int Val;

    }

}
