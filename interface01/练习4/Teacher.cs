//------------------------------------------------------------------------------
// <copyright file="Teacher.cs" company="PlaceholderCompany">
// LZM
// </copyright>
// <文件名称>Teacher.cs</文件名称>
// <作者>LZM\Administrator</作者>
// <创建日期>2021/4/30 19:35:07</创建日期>
//------------------------------------------------------------------------------

namespace interface01.练习4
{
    using System;

    /// <summary>
    /// Defines the <see cref="Teacher" />.
    /// </summary>
    public class Teacher : Person, ICollect
    {
        #region Methods

        /// <summary>
        /// The Collect.
        /// </summary>
        public void Collect()
        {
            Console.WriteLine("老师收作业");
        }

        #endregion
    }
}
