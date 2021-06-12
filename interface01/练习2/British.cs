// <copyright file="British.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// <author>LZM\Administrator </author>
// <date>2021/4/29 18:57:50</date>

namespace interface01.练习2
{
    using interface01.练习3;
    using System;

    /// <summary>
    /// Defines the <see cref="British" />.
    /// 英国人继承人类，实现了IItroduce接口.
    /// </summary>
    internal class British : Person, IIntroduce
    {
        #region Methods

        /// <summary>
        /// 实现Introduce方法.
        /// </summary>
        public new void Introduce()
        {
            Console.WriteLine("我是英国人");
        }

        #endregion
    }
}
