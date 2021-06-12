// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// <author>LZM\Administrator </author>
// <date>2021/4/28 20:10:00</date>

namespace interface01
{
    using interface01.练习2;
    using interface01.练习3;

    /// <summary>
    /// Defines the <see cref="Program" />.
    /// </summary>
    internal class Program
    {
        #region Methods

        /// <summary>
        /// The DengJi.
        /// </summary>
        /// <param name="djobj">The djobj<see cref="IIntroduce"/>.</param>
        private static void DengJi(IIntroduce djobj)
        {
            djobj.Introduce();
        }

        /// <summary>
        /// The Main.
        /// </summary>
        /// <param name="args">The args<see cref="Main(string[])"/>.</param>
        private static void Main(string[] args)
        {
            /*
            SuperMan sm = new SuperMan();
            sm.fly();
            sm.Jump();
            */
            /*
            Person c1 = new Chinese();
            c1.Introduce();
            */
            House h = new();
            DengJi(h);
            Person person = new Chinese();
            DengJi(person);
        }

        #endregion Methods
    }
}