using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookDB.Abstract;
using BookDB.Entities;

namespace BookDB
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        //тут создам базу и заполню, а потом сделаю миграцию
        //        using (var db = new BookDB_Context())
        //        {

        //            var Styles = new List<Style>
        //            {
        //                new Style{ NameStyle = "Художественный"},
        //                new Style{ NameStyle = "Научный"},
        //                new Style{ NameStyle = "Публик"}
        //            };
        //            Styles.ForEach(s => db.Styles.Add(s));

        //            var Genres = new List<Genre>
        //            {
        //                new Genre { NameGenre = "Сказка", Style = Styles[0] },
        //                new Genre { NameGenre = "Комедия", Style = Styles[0] },
        //                new Genre { NameGenre = "Статья", Style = Styles[1] },
        //            };
        //            Genres.ForEach(s => db.Genres.Add(s));

        //            var Books = new List<Book> 
        //            { 
        //                new Book { Title = "Carson",   Price = 25.0m, PublishYear = DateTime.Parse("2005-09-01"), Genre = Genres[2] }, 
        //                new Book { Title = "Meredith", Price = 30.0m, PublishYear = DateTime.Parse("2002-09-01"), Genre = Genres[2] }, 
        //                new Book { Title = "Arturo",   Price = 35.0m, PublishYear = DateTime.Parse("2003-09-01"), Genre = Genres[2] }
        //            };
        //            Books.ForEach(s => db.Books.Add(s));

        //            db.SaveChanges();

        //            Console.WriteLine("Good");
        //        }
        //    }
        //    catch(Exception e)
        //    {
        //        Console.WriteLine("No create database: Original error", e.Message);
        //    }
        //    Console.ReadLine();
        //}
    }
}
