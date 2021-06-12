// <copyright file="American.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// <author>LZM\Administrator </author>
// <date>2021/4/29 18:57:50</date>

namespace interface01.练习2
{
    using interface01.练习3;
    using System;

    /// <summary>
    /// Defines the <see cref="American" />.、
    /// 美国人继承了人类，实现了IItroduce接口.
    /// </summary>
    internal class American : Person, IIntroduce
    {
        #region Methods

        /// <summary>
        /// 实现了Introduce方法.
        /// </summary>
        public new void Introduce()
        {
            Console.WriteLine("我是美国人");
        }

        #endregion
    }
}
