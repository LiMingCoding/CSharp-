//------------------------------------------------------------------------------
// <copyright file="Program.cs" company="PlaceholderCompany">
// LZM
// </copyright>
// <文件名称>Program.cs</文件名称>
// <作者>LZM\Administrator</作者>
// <创建日期>2021/6/12 20:04:24</创建日期>
//------------------------------------------------------------------------------

namespace 判断两个对象是否相同
{
    using System;

    /// <summary>
    /// Defines the <see cref="Program" />.
    /// </summary>
    internal class Program
    {
        #region Methods

        /// <summary>
        /// The Main.
        /// </summary>
        /// <param name="args">The args<see cref="string[]"/>.</param>
        internal static void Main(string[] args)
        {
            Person p1 = new()
            {
                Age = 12,
                Name = "爱因斯坦"
            };
            Person p2 = new()
            {
                Age = 12,
                Name = "爱因斯坦"
            };
            //p1 和 p2 是否是同一个对象?否
            Person p3 = new();
            p3 = p1;
            //p1和p3是同一个对象

            Console.WriteLine(p1.Equals(p2));//false
            Console.WriteLine(p1 == p2);//false
            Console.WriteLine(p1.Equals(p3));//true
            Console.WriteLine(p1 == p3);//true
            Console.ReadKey();

            string[] names = new string[] { "张三", "李四", "王五" };
            string[] names1 = new string[] { "张三", "李四", "王五" };
            Console.WriteLine(names.Equals(names1));//false
            Console.WriteLine(names == names1);//false

            string s1 = new string(new char[] { 'a', 'b', 'c' });
            string s2 = new string(new char[] { 'a', 'b', 'c' });
            Console.WriteLine(s1.Equals(s2));//true
            Console.WriteLine(s1 == s2);//true
        }

        #endregion
    }
}
