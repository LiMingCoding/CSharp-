// <copyright file="Parrot.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// <author>LZM\Administrator </author>
// <date>2021/4/28 20:45:51</date>

namespace interface01.练习1
{
    using System;

    /// <summary>
    /// Defines the <see cref="Parrot" />.
    /// 鹦鹉类继承鸟类，扩展了IFlyable接口.
    /// </summary>
    public class Parrot : Bird, IFlyable
    {
        #region Methods

        /// <summary>
        /// 实现了Fly方法.
        /// </summary>
        public void fly()
        {
            Console.WriteLine("Parrot able fly");
        }

        #endregion
    }
}
