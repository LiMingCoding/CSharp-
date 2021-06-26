//------------------------------------------------------------------------------
// <copyright file="Primes.cs" company="PlaceholderCompany">
// LZM
// </copyright>
// <文件名称>Primes.cs</文件名称>
// <作者>LZM\Administrator</作者>
// <创建日期>2021/6/26 21:43:56</创建日期>
//------------------------------------------------------------------------------

namespace 迭代器
{
    using System;
    using System.Collections;

    /// <summary>
    /// Defines the <see cref="Primes" />.
    /// </summary>
    public class Primes
    {
        #region Fields

        /// <summary>
        /// Defines the max.
        /// </summary>
        private long max;

        /// <summary>
        /// Defines the min.
        /// </summary>
        private long min;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Primes"/> class.
        /// </summary>
        public Primes() : this(2, 100)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Primes"/> class.
        /// </summary>
        /// <param name="minium">The minium<see cref="long"/>.</param>
        /// <param name="maxium">The maxium<see cref="long"/>.</param>
        public Primes(long minium, long maxium)
        {
            if (minium < 2)
            {
                min = 2;
            }
            else
            {
                min = minium;
            }
            max = maxium;
        }

        #endregion

        #region Methods

        /// <summary>
        /// The GetEnumerator.
        /// </summary>
        /// <returns>The <see cref="IEnumerator"/>.</returns>
        public IEnumerator GetEnumerator()
        {
            for (long possiblePrime = min; possiblePrime <= max; possiblePrime++)
            {
                bool isPrime = true;
                for (long possibleFactor = 2; possibleFactor <= (long)Math.Floor(Math.Sqrt(possiblePrime)); possibleFactor++)
                {
                    long remainderAfterDivision = possiblePrime % possibleFactor;
                    if (remainderAfterDivision == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    yield return possiblePrime;
                }
            }
        }

        #endregion
    }
}
