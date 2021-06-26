//------------------------------------------------------------------------------
// <copyright file="Checker.cs" company="PlaceholderCompany">
// LZM
// </copyright>
// <文件名称>Checker.cs</文件名称>
// <作者>LZM\Administrator</作者>
// <创建日期>2021/6/26 22:44:53</创建日期>
//------------------------------------------------------------------------------

namespace is运算符
{
    using System;

    /// <summary>
    /// Defines the <see cref="Checker" />.
    /// </summary>
    public class Checker
    {
        #region Methods

        /// <summary>
        /// The Check.
        /// </summary>
        /// <param name="param1">The param1<see cref="object"/>.</param>
        public void Check(object param1)
        {
            if (param1 is ClassA)
            {
                Console.WriteLine("Variable can be converted to ClassA.");
            }
            else
            {
                Console.WriteLine("Variable can't be converted to ClassA.");
            }
            if (param1 is IMyInterface)
            {
                Console.WriteLine("Variable can be converted to IMyInterface.");
            }
            else
            {
                Console.WriteLine("Variable can't be converted to IMyInterface.");
            }
        }

        #endregion
    }
}
