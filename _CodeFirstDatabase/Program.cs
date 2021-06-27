//------------------------------------------------------------------------------
// <copyright file="Program.cs" company="PlaceholderCompany">
// LZM
// </copyright>
// <文件名称>Program.cs</文件名称>
// <作者>LZM\Administrator</作者>
// <创建日期>2021/6/28 20:20:05</创建日期>
//------------------------------------------------------------------------------

namespace _CodeFirstDatabase
{
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using System.Data;
    using System.Data.Entity;
    using System.Linq;
    using static System.Console;
    using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

    /// <summary>
    /// Defines the <see cref="Book" />.
    /// </summary>
    public class Book
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Author.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets the Code.
        /// </summary>
        [Key] public int Code { get; set; }

        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        public string Title { get; set; }

        #endregion
    }

    /// <summary>
    /// Defines the <see cref="BookContent" />.
    /// </summary>
    public class BookContent : DbContext
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Books.
        /// </summary>
        public DbSet<Book> Books { get; set; }

        #endregion
    }

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
        private static void Main(string[] args)
        {
            using (var db = new BookContent())
            {
                Book book1 = new Book { Title = "Beginning Visual C# 2015", Author = "Perkins,Rid,And Hammer" };
                db.Books.Add(book1);
                Book book2 = new Book { Title = "Beginning XML", Author = "Fawcett,Quin,and Ayers" };
                db.Books.Add(book2);
                db.SaveChanges();
                var query = from b in db.Books
                            orderby b.Title
                            select b;
                WriteLine("All books in the database: ");

                foreach (var b in query)
                {
                    WriteLine($"{b.Title} by {b.Author},code={b.Code}");
                }
                WriteLine("Perss a key to exit...");
                ReadKey();
            }
        }

        #endregion
    }
}
