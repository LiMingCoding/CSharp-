// <copyright file="Chinese.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// <author>LZM\Administrator </author>
// <date>2021/4/29 18:57:50</date>

namespace interface01.练习2
{
    using interface01.练习3;
    using System;

    /// <summary>
    /// Defines the <see cref="Chinese" />.
    /// 中国人继承人类，扩展了IIntroduce接口.
    /// </summary>
    internal class Chinese : Person, IIntroduce
    {
        #region Methods

        /// <summary>
        /// 实现Introduce方法.
        /// </summary>
        public new void Introduce()
        {
            Console.WriteLine("我的户口，身份证号码");
        }

        #endregion
    }
}
