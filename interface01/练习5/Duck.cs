//------------------------------------------------------------------------------
// <copyright file="Duck.cs" company="PlaceholderCompany">
// LZM
// </copyright>
// <文件名称>Duck.cs</文件名称>
// <作者>LZM\Administrator</作者>
// <创建日期>2021/4/30 19:50:36</创建日期>
//------------------------------------------------------------------------------

namespace interface01.练习5
{
    using System;

    #region Interfaces

    /// <summary>
    /// Defines the <see cref="IBarkable" />.
    /// </summary>
    public interface IBarkable
    {
        #region Methods

        /// <summary>
        /// The Bark.
        /// </summary>
        void Bark();

        #endregion
    }

    #endregion

    /// <summary>
    /// Defines the <see cref="Duck" />.
    /// </summary>
    public class Duck
    {
        #region Methods

        /// <summary>
        /// The Swim.
        /// </summary>
        public void Swim()
        {
            Console.WriteLine("鸭子会游泳");
        }

        #endregion
    }
}
