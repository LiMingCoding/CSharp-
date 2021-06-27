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
    using System.Data;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="Program" />.
    /// </summary>
    internal class Program
    {
        #region Methods

        /// <summary>
        /// The Main.
        /// </summary>
        /// <param name="args">The args<see cref="string[]"/>.</param>
        internal static void Main(string[] args)
        {
            using (var db = new BookContext())
            {
                Book book1 = new Book { Title = "Beginning Visual C# 2015", Author = "Perkins,Rid,And Hammer" };
                db.Books.Add(book1);
                Book book2 = new Book { Title = "Beginning XML", Author = "Fawcett,Quin,and Ayers" };
                db.Books.Add(book2);
                var store1 = new Store
                {
                    Name = "Main St Books",
                    Address = "123 Main St",
                    Inventory = new List<Stock>()
                };
                db.Stores.Add(store1);
                Stock store1book1 = new Stock
                {
                    Item = book1,
                    OnHand = 4,
                    OnOrder = 6
                };
                store1.Inventory.Add(store1book1);
                Stock store1book2 = new Stock
                {
                    Item = book2,
                    OnHand = 1,
                    OnOrder = 9
                };
                store1.Inventory.Add(store1book2);
                var store2 = new Store
                {
                    Name = "123",
                    Address = "123 st",
                    Inventory = new List<Stock>()
                };
                db.Stores.Add(store2);
                Stock store2book1 = new Stock
                {
                    Item = book1,
                    OnHand = 7,
                    OnOrder = 23
                };
                store2.Inventory.Add(store2book1);
                Stock store2book2 = new Stock
                {
                    Item = book2,
                    OnHand = 2,
                    OnOrder = 8,
                };
                store2.Inventory.Add(store2book2);
                db.SaveChanges();
                var query = from store in db.Stores
                            orderby store.Name
                            select store;
                System.Console.WriteLine("Bookstore Inventory Report: ");
                foreach (var store in query)
                {
                    System.Console.WriteLine($"{store.Name} located at {store.Address}");
                    foreach (Stock stock in store.Inventory)
                    {
                        System.Console.WriteLine($"- Title:{stock.Item.Title}");
                        System.Console.WriteLine($"--Copies in Store: {stock.OnHand}");
                        System.Console.WriteLine($"--Copies onOrder:{stock.OnOrder}");
                    }
                }
                System.Console.WriteLine("Press a key to exit...");
                System.Console.ReadKey();

            }
        }

        #endregion
    }
}
