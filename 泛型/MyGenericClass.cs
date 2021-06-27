//------------------------------------------------------------------------------
// <copyright file="MyGenericClass.cs" company="PlaceholderCompany">
// LZM
// </copyright>
// <文件名称>MyGenericClass.cs</文件名称>
// <作者>LZM\Administrator</作者>
// <创建日期>2021/6/27 9:59:14</创建日期>
//------------------------------------------------------------------------------

namespace 泛型
{
    /// <summary>
    /// Defines the <see cref="MyGenericClass{T1,T2,T3}" />.
    /// </summary>
    /// <typeparam name="T1">.</typeparam>
    /// <typeparam name="T2">.</typeparam>
    /// <typeparam name="T3">.</typeparam>
    public class MyGenericClass<T1, T2, T3>
    {
        #region Fields

        /// <summary>
        /// Defines the innerT1Object.
        /// </summary>
        private T1 innerT1Object;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MyGenericClass{T1,T2,T3}"/> class.
        /// </summary>
        /// <param name="item">The item<see cref="T1"/>.</param>
        public MyGenericClass(T1 item)
        {
            innerT1Object = item;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the InnerT1Object.
        /// </summary>
        public T1 InnerT1Object
        {
            get { return innerT1Object; }
        }

        #endregion
    }
}
