//------------------------------------------------------------------------------
// <copyright file="AddClass1.cs" company="PlaceholderCompany">
// LZM
// </copyright>
// <文件名称>AddClass1.cs</文件名称>
// <作者>LZM\Administrator</作者>
// <创建日期>2021/6/26 22:49:38</创建日期>
//------------------------------------------------------------------------------

namespace 重载操作符
{
    /// <summary>
    /// Defines the <see cref="AddClass1" />.
    /// </summary>
    public class AddClass1
    {
        #region Fields

        /// <summary>
        /// Defines the val.
        /// </summary>
        public int val;

        #endregion


        public static AddClass1 operator +(AddClass1 op1, AddClass1 op2)
        {
            AddClass1 returnVal = new AddClass1();
            returnVal.val = op1.val + op2.val;
            return returnVal;
        }

        public static AddClass1 operator -(AddClass1 op1)
        {
            AddClass1 returnVal = new AddClass1();
            returnVal.val = -op1.val;
            return returnVal;
        }
    }
}
