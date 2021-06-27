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
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Defines the <see cref="Store" />.
    /// </summary>
    public class Store
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the Inventory.
        /// </summary>
        public virtual List<Stock> Inventory { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the StoreId.
        /// </summary>
        [Key]
        public int StoreId { get; set; }

        #endregion
    }
}
