// <copyright file="Sparrow.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// <author>LZM\Administrator </author>
// <date>2021/4/28 20:45:51</date>

namespace interface01.练习1
{
    using System;

    /// <summary>
    /// Defines the <see cref="Sparrow" />.
    /// 麻雀继承鸟类，并且扩展了IFlyable接口.
    /// </summary>
    public class Sparrow : Bird, IFlyable
    {
        #region Methods

        /// <summary>
        /// 实现接口内的Fly方法.
        /// </summary>
        public void fly()
        {
            Console.WriteLine("Sparrow able fly ");
        }

        #endregion
    }
}
