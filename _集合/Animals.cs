//------------------------------------------------------------------------------
// <copyright file="Animals.cs" company="PlaceholderCompany">
// LZM
// </copyright>
// <文件名称>Animals.cs</文件名称>
// <作者>LZM\Administrator</作者>
// <创建日期>2021/6/26 21:11:32</创建日期>
//------------------------------------------------------------------------------

namespace _集合
{
    using System.Collections;

    public class Animals : CollectionBase
    {
        public void Add(Animal newAnimal)
        {
            List.Add(newAnimal);
        }

        public void Remove(Animal newAnimal)
        {
            List.Remove(newAnimal);
        }

        public Animal this[int animalIndex]
        {
            get { return (Animal)List[animalIndex]; }
            set { List[animalIndex] = value; }
        }
    }
}