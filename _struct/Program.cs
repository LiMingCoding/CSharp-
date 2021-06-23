//------------------------------------------------------------------------------
// <copyright file="Program.cs" company="PlaceholderCompany">
// LZM
// </copyright>
// <文件名称>Program.cs</文件名称>
// <作者>LZM\Administrator</作者>
// <创建日期>2021/6/23 20:37:43</创建日期>
//------------------------------------------------------------------------------

namespace _struct
{
    using System;

    /// <summary>
    /// Defines the <see cref="myStruct" />.
    /// </summary>
    internal struct myStruct
    {
        #region Fields

        /// <summary>
        /// Defines the val.
        /// </summary>
        public int val;

        #endregion Fields
    }

    /// <summary>
    /// Defines the <see cref="MyClass" />.
    /// </summary>
    internal class MyClass
    {
        #region Fields

        /// <summary>
        /// Defines the val.
        /// </summary>
        public int val;

        #endregion Fields
    }

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
            MyClass myClass = new MyClass();
            MyClass myClass1 = myClass;
            myClass.val = 10;
            myClass1.val = 20;
            myStruct myStruct1 = new myStruct();
            myStruct myStruct2 = myStruct1;
            myStruct1.val = 30;
            myStruct2.val = 40;
            Console.WriteLine($"myclass.val={myClass.val}");
            Console.WriteLine($"myclass1.val={myClass1.val}");
            Console.WriteLine($"myStruct1.val={myStruct1.val}");
            Console.WriteLine($"myStruct2.val={myStruct2.val}");
        }

        #endregion Methods
    }
}