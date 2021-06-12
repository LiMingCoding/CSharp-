## 显式实现接口

```C#
#region Interfaces

    /// <summary>
    /// Defines the <see cref="IFace1" />.
    /// </summary>
    interface IFace1
    {
        #region Methods

        /// <summary>
        /// The Fly.
        /// </summary>
        public void Fly();

        #endregion
    }

    /// <summary>
    /// Defines the <see cref="IFace2" />.
    /// </summary>
    interface IFace2
    {
        #region Methods

        /// <summary>
        /// The Fly.
        /// </summary>
        public void Fly();

        #endregion
    }

    #endregion

    /// <summary>
    /// Defines the <see cref="Person" />.
    /// </summary>
    public class Person : IFace1, IFace2
    {
        #region Methods

        /// <summary>
        /// The Fly.
        /// </summary>
        public  void Fly()
        {
            Console.WriteLine("实现IFace1中的Fly()");
        }

        /// <summary>
        /// The Fly.
        /// </summary>
        void IFace2.Fly()
        {
            Console.WriteLine("实现IFace2中的Fly()");
        }

        #endregion
    }
```

显式实现接口必须是private，只能通过接口来调用，不能通过类对象本身调用。显式实现
接口可以解决重名的问题。
