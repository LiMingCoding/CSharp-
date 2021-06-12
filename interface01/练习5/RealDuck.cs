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

    /// <summary>
    /// Defines the <see cref="RealDuck" />.
    /// </summary>
    public class RealDuck : Duck, IBarkable
    {
        #region Methods

        /// <summary>
        /// The Bark.
        /// </summary>
        public void Bark()
        {
            Console.WriteLine("真实的鸭子嘎嘎叫");
        }

        #endregion
    }
}
