//------------------------------------------------------------------------------
// <copyright file="Person.cs" company="PlaceholderCompany">
// LZM
// </copyright>
// <文件名称>Person.cs</文件名称>
// <作者>LZM\Administrator</作者>
// <创建日期>2021/4/30 20:04:51</创建日期>
//------------------------------------------------------------------------------

namespace interface02.显示实现接口
{
    using System;

    #region Interfaces

    /// <summary>
    /// Defines the <see cref="IFace1" />.
    /// </summary>
    interface IFace1
    {
        #region Methods

        /// <summary>
        /// The Fly.
        /// </summary>
        public void Fly();

        #endregion
    }

    /// <summary>
    /// Defines the <see cref="IFace2" />.
    /// </summary>
    interface IFace2
    {
        #region Methods

        /// <summary>
        /// The Fly.
        /// </summary>
        public void Fly();

        #endregion
    }

    #endregion

    /// <summary>
    /// Defines the <see cref="Person" />.
    /// </summary>
    public class Person : IFace1, IFace2
    {
        #region Methods

        /// <summary>
        /// The Fly.
        /// </summary>
        public  void Fly()
        {
            Console.WriteLine("实现IFace1中的Fly()");
        }

        /// <summary>
        /// The Fly.
        /// </summary>
        void IFace2.Fly()
        {
            Console.WriteLine("实现IFace2中的Fly()");
        }

        #endregion
    }
}
