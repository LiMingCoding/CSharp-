//------------------------------------------------------------------------------
// <copyright file="Program.cs" company="PlaceholderCompany">
// LZM
// </copyright>
// <文件名称>Program.cs</文件名称>
// <作者>LZM\Administrator</作者>
// <创建日期>2021/6/23 19:53:10</创建日期>
//------------------------------------------------------------------------------

namespace 面向对象
{
    using System;

    #region Interfaces

    /// <summary>
    /// Defines the <see cref="IMyBaseInterface" />.
    /// </summary>
    public interface IMyBaseInterface
    {
    }

    /// <summary>
    /// Defines the <see cref="IMyBaseInterface2" />.
    /// </summary>
    internal interface IMyBaseInterface2
    {
    }

    /// <summary>
    /// Defines the <see cref="IMyInterface" />.
    /// </summary>
    internal interface IMyInterface : IMyBaseInterface, IMyBaseInterface2
    {
    }

    #endregion

    /// <summary>
    /// Defines the <see cref="MyBase" />.
    /// </summary>
    public abstract class MyBase
    {
    }

    /// <summary>
    /// Defines the <see cref="MyClass" />.
    /// </summary>
    internal class MyClass : MyBase
    {
    }

    /// <summary>
    /// Defines the <see cref="MyComplexClass" />.
    /// </summary>
    internal sealed class MyComplexClass : MyClass, IMyInterface
    {
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
            MyComplexClass myObj = new();
            Console.WriteLine(myObj.ToString());
        }

        #endregion
    }
}
