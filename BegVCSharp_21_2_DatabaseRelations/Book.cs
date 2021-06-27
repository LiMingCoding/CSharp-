//------------------------------------------------------------------------------
// <copyright file="Program.cs" company="PlaceholderCompany">
// LZM
// </copyright>
// <文件名称>Program.cs</文件名称>
// <作者>LZM\Administrator</作者>
// <创建日期>2021/6/28 20:20:14</创建日期>
//------------------------------------------------------------------------------

namespace BegVCSharp_21_2_DatabaseRelations
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Defines the <see cref="Book" />.
    /// </summary>
    public class Book
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Author.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets the Code.
        /// </summary>
        [Key]
        public int Code { get; set; }

        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        public string Title { get; set; }

        #endregion
    }
}
