//------------------------------------------------------------------------------
// <copyright file="Chicken.cs" company="PlaceholderCompany">
// LZM
// </copyright>
// <文件名称>Chicken.cs</文件名称>
// <作者>LZM\Administrator</作者>
// <创建日期>2021/6/26 20:00:01</创建日期>
//------------------------------------------------------------------------------

namespace _集合
{
    using System;

    /// <summary>
    /// Defines the <see cref="Chicken" />.
    /// </summary>
    public class Chicken : Animal
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Chicken"/> class.
        /// </summary>
        /// <param name="newName">The newName<see cref="string"/>.</param>
        public Chicken(string newName) : base(newName)
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// The LayEgg.
        /// </summary>
        public void LayEgg() => Console.WriteLine($"{name} has laid an egg.");

        #endregion
    }
}
