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
    /// Defines the <see cref="Stock" />.
    /// </summary>
    public class Stock
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Item.
        /// </summary>
        public virtual Book Item { get; set; }

        /// <summary>
        /// Gets or sets the OnHand.
        /// </summary>
        public int OnHand { get; set; }

        /// <summary>
        /// Gets or sets the OnOrder.
        /// </summary>
        public int OnOrder { get; set; }

        /// <summary>
        /// Gets or sets the StockId.
        /// </summary>
        [Key]
        public int StockId { get; set; }

        #endregion
    }
}
