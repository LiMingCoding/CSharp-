//------------------------------------------------------------------------------
// <copyright file="SuperMan.cs" company="PlaceholderCompany">
// LZM
// </copyright>
// <文件名称>SuperMan.cs</文件名称>
// <作者>LZM\Administrator</作者>
// <创建日期>2021/4/29 23:41:11</创建日期>
//------------------------------------------------------------------------------

namespace interface01
{
    using interface01.练习1;
    using System;

    /// <summary>
    /// Defines the <see cref="SuperMan" />.
    /// </summary>
    public class SuperMan : IFlyable
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SuperMan"/> class.
        /// </summary>
        public SuperMan()
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// 实现了IFlyable接口的Fly方法.
        /// </summary>
        public void fly()
        {
            Console.WriteLine("超人在飞");
        }

        /// <summary>
        /// Jump方法.
        /// </summary>
        public void Jump()
        {
            Console.WriteLine("超人在跳");
        }

        #endregion
    }
}
