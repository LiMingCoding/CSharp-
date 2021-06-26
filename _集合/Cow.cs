//------------------------------------------------------------------------------
// <copyright file="Cow.cs" company="PlaceholderCompany">
// LZM
// </copyright>
// <文件名称>Cow.cs</文件名称>
// <作者>LZM\Administrator</作者>
// <创建日期>2021/6/26 19:50:01</创建日期>
//------------------------------------------------------------------------------

namespace _集合
{
    using System;

    /// <summary>
    /// Defines the <see cref="Cow" />.
    /// </summary>
    public class Cow : Animal
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Cow"/> class.
        /// </summary>
        /// <param name="newName">The newName<see cref="string"/>.</param>
        public Cow(string newName) : base(newName)
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// 定义牛奶方法
        /// The Milk.
        /// </summary>
        public void Milk() => Console.WriteLine($"{name} has been milked.");

        #endregion
    }
}
