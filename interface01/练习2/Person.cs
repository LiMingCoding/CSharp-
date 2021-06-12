// <copyright file="Person.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// <author>LZM\Administrator </author>
// <date>2021/4/29 18:57:50</date>

namespace interface01.练习2
{
    using interface01.练习3;

    /// <summary>
    /// Defines the <see cref="Person" />.
    /// 定义一个人类，会自我介绍.
    /// </summary>
    public class Person : IIntroduce
    {
        #region Methods

        /// <summary>
        /// 自我介绍的方法.
        /// </summary>
        public void Introduce()
        {
            System.Console.WriteLine("我是人类");
        }

        #endregion
    }
}
