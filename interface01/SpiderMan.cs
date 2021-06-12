// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// <author>LZM\Administrator </author>
// <date>2021/4/28 20:10:00</date>

namespace interface01
{
    using interface01.练习1;

    /// <summary>
    /// Defines the <see cref="SpiderMan" />.
    /// </summary>
    public class SpiderMan : IFlyable
    {
        #region Methods

        /// <summary>
        /// The Jump.
        /// </summary>
        public static void Jump()
        {
            System.Console.WriteLine("蜘蛛侠会跳");
        }

        /// <summary>
        /// The fly.
        /// </summary>
        public void fly()
        {
            System.Console.WriteLine("蜘蛛侠会飞");
        }

        #endregion
    }
}
