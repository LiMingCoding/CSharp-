using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 集合
{
    class _ArrayList
    {
        public static void testArrayList()
        {
            #region ArrayList集合，类似于一个object数组
            Person person = new();
            person.Name = "张三";
            ArrayList arrayList = new()
            {
                1.0,
                99.9,
                12.0,
                22.0
                //"hello"
                //person
                //false
            };
            Console.WriteLine($"arrayList 集合中有{arrayList.Count}个元素+{arrayList.Capacity}容量");
            //arrayList.Insert(0, "===========");
            int[] arr = new int[] { 1, 2, 3 };
            string[] names = new string[] { "乔丹","丹妮"};
            //arrayList.AddRange(arr);
            //arrayList.AddRange(names);
            arrayList.RemoveAt(0);
            //根据元素内容来删除，内部通过调用Equals()方法来实现的比较，所以只要Equals（）方法返回值为true，即可删除。
            arrayList.Remove("丹妮");
            //Contains（）判断是否包含这个元素
            Console.WriteLine("排序之前++++++++++");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i].ToString());
            }
            arrayList.Sort();
            Console.WriteLine("排序之后++++++++++++++++++");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i].ToString());
            }
            Array.Clear(arr, 0, arr.Length);
            Console.WriteLine("=================================");
            Console.WriteLine(arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]}+★");
            }
            


            #endregion
        }

    }
    class Person
    {
        public String Name { get; set; }
    }
}
