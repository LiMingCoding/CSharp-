// <copyright file="Bird.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// <author>LZM\Administrator </author>
// <date>2021/4/28 20:45:40</date>

namespace interface01.练习1
{
    using System;

    /// <summary>
    /// Defines the <see cref="Bird" />.
    /// 定义一个鸟类，作为基类.
    /// </summary>
    public class Bird
    {
        #region Methods

        /// <summary>
        /// Eat()方法是子类都可以继承的方法.
        /// </summary>
        public void Eat()
        {
            Console.WriteLine("bird is eating");
        }

        #endregion
    }
}
