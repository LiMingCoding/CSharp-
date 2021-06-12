//------------------------------------------------------------------------------
// <copyright file="Program.cs" company="PlaceholderCompany">
// LZM
// </copyright>
// <文件名称>Program.cs</文件名称>
// <作者>LZM\Administrator</作者>
// <创建日期>2021/4/30 20:28:20</创建日期>
//------------------------------------------------------------------------------

namespace interface02
{
    using interface02.显示实现接口;

    /// <summary>
    /// Defines the <see cref="Program" />.
    /// </summary>
    internal class Program
    {
        #region Methods

        /// <summary>
        /// The Main.
        /// </summary>
        /// <param name="args">The args<see cref="string[]"/>.</param>
        internal static void Main(string[] args)
        {
            Person p = new Person();
            p.Fly();
            IFace1 p1 = new Person();
            p1.Fly();
            IFace2 p2 = new Person();
            p2.Fly();
        }

        #endregion
    }
}
