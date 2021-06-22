using System;

namespace 垃圾回收
{
    class Program
    {
        static void Main(string[] args)
        {
            //值类型不需要垃圾回收，当执行完毕后，立即出栈就释放内存。
            Person p = new Person
            {
                Age = 19,
                Name = "张三"
            };
            Console.WriteLine($"{p.Name}{p.Age}");
        }
    }
}