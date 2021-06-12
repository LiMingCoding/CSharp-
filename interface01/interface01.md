# 接口
## 定义接口

```C#
    public interface IFlyable
    {
        void fly();
        void Jump();
    }
```

定义一个接口，定义接口使用 **interface** 关键字
一般接口名称要以大写字母 **I** 开头，接口中只能包含方法，例如属性，事件，索引器。
接口中的成员不能有任何访问修饰符，默认是**public**，如果手动修改访问修饰符将会引起编译器报错。
接口中的成员不能有任何实现，就像抽象方法一样不能有具体实现。

## 实现接口

```C#

    public class SuperMan : IFlyable
    {
        public SuperMan()
        {
        }

        public void fly()
        {
            throw new NotImplementedException();
        }

        public void Jump()
        {
            throw new NotImplementedException();
        }
    }
```

定义一个类实现IFlayable接口，实现接口的类，必须将接口中的所有成员全部实现，
实现接口的类直接实现接口中的方法即可，无需使用**override**关键字。

## 怎么实现多态？
### 什么是接口？

接口是一种规范或者协议，约定好遵守某种规范就可以了写通用的代码。
定义了一组具有各种功能的方法。（只是一种能力，没有具体实现，像抽象方法一样）
接口存在的意义是方便实现多态，增强程序可扩展性，节省成本，提高效率。

接口解决了类的多继承问题。

接口解决了类继承后体积庞大的问题。

接口之间可以实现多继承。

### 何时使用接口？

使用抽象类和虚方法已经完全可以实现多态，为什么还需要使用接口实现多态？

什么情况下使用接口来实现多态？
1. 当多个类型不能抽象出合理的父类的时候，但是又要对某些方法进行多态.
2.  因为一个类可以实现多个接口，解决了类的单继承问题，当一个类需要“继承”多个类的行为时，可以考虑使用接口实现多态。

### 练习鸭子模型

首先创建一个鸭子父类，默认父类拥有游泳的方法。

```C#
public class Duck
    {
        #region Methods

        /// <summary>
        /// The Swim.
        /// </summary>
        public void Swim()
        {
            Console.WriteLine("鸭子会游泳");
        }

        #endregion
    }
```

创建WoodDuck，RubberDuck，RealDuck子类

```C#

    /// <summary>
    /// Defines the <see cref="WoodDuck" />.
    /// </summary>
    public class WoodDuck : Duck
    {
    }

    /// <summary>
    /// Defines the <see cref="RubberDuck" />.
    /// </summary>
    public class RubberDuck : Duck, IBarkable
    {
        #region Methods

        /// <summary>
        /// The Bark.
        /// </summary>
        public void Bark()
        {
            Console.WriteLine("橡皮鸭子唧唧叫");
        }

        #endregion
    }

    /// <summary>
    /// Defines the <see cref="RealDuck" />.
    /// </summary>
    public class RealDuck : Duck, IBarkable
    {
        #region Methods

        /// <summary>
        /// The Bark.
        /// </summary>
        public void Bark()
        {
            Console.WriteLine("真实的鸭子嘎嘎叫");
        }

        #endregion
    }

```












