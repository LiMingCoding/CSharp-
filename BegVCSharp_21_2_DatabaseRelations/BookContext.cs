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
    using System.Data.Entity;

    /// <summary>
    /// Defines the <see cref="BookContext" />.
    /// </summary>
    public class BookContext : DbContext
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Books.
        /// </summary>
        public DbSet<Book> Books { get; set; }

        /// <summary>
        /// Gets or sets the Stocks.
        /// </summary>
        public DbSet<Stock> Stocks { get; set; }

        /// <summary>
        /// Gets or sets the Stores.
        /// </summary>
        public DbSet<Store> Stores { get; set; }

        #endregion
    }
}
