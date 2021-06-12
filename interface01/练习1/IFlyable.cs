// <copyright file="IFlyable.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// <author>LZM\Administrator </author>
// <date>2021/4/28 20:10:00</date>

namespace interface01.练习1
{
    #region Interfaces

    /// <summary>
    /// Defines the <see cref="IFlyable" />.
    /// 飞翔的接口.
    /// </summary>
    public interface IFlyable
    {
        #region Methods

        /// <summary>
        /// 飞翔的方法，接口内的方法默认修饰符为public,且不可以更改.
        /// </summary>
        void fly();

        #endregion
    }

    #endregion
}
