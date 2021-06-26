//------------------------------------------------------------------------------
// <copyright file="Animal.cs" company="PlaceholderCompany">
// LZM
// </copyright>
// <文件名称>Animal.cs</文件名称>
// <作者>LZM\Administrator</作者>
// <创建日期>2021/6/26 19:44:13</创建日期>
//------------------------------------------------------------------------------

namespace _集合
{
    using System;

    /// <summary>
    /// 定义一个动物的抽象类
    /// Defines the <see cref="Animal" />.
    /// </summary>
    public abstract class Animal
    {
        #region Fields

        /// <summary>
        /// 字段 string name
        /// Defines the name.......
        /// </summary>
        protected string name;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Animal"/> class.
        /// </summary>
        public Animal()
        {
            name = "The animal with no name";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Animal"/> class.
        /// </summary>
        /// <param name="newName">The newName<see cref="string"/>.</param>
        public Animal(string newName)
        {
            name = newName;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the Name
        /// 属性Name，包含get 和 set方法
        /// Gets or sets the Name......
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// 喂养方法
        /// The Feed.
        /// </summary>
        public void Feed() => Console.WriteLine($"{name} has been fed.");

        #endregion
    }
}
