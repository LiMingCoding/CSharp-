//<文件名称>House.cs</文件名称>
//<作者>XTZJ-20210429FE\Administrator\LZM</作者>
//<创建日期>2021/4/29 22:28:51</创建日期>

namespace interface01.练习3
{
    using System;

    /// <summary>
    /// Defines the <see cref="House" />.
    /// </summary>
    internal class House : IIntroduce
    {
        #region Methods

        /// <summary>
        /// The Introduce.
        /// </summary>
        public void Introduce()
        {
            Console.WriteLine("我是房子");
        }

        #endregion
    }
}
