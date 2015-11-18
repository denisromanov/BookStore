using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookDB.Abstract;
using BookDB.Entities;
using System.Data.Entity;

namespace BookDB
{
    public class BookRepository : IBookRepository<Book>
    {
        private BookDB_Context db;

        public BookRepository()
        {
            db = new BookDB_Context();
        }

        //Get list all 
        public IEnumerable<Book> GetAll()
        {
            return db.Books;
        }

        //Creates a Book object in db
        public void Create(Book book)
        {
            if (book != null)
            {
                db.Books.Add(book);
            }
        }

        //Update
        public void Update(Book book)
        {
            db.Entry(book).State = EntityState.Modified;
        }

        //Delete a Book from db
        public void Delete(int id)
        {
            var pic = db.Books.Find(id);
            if (pic != null)
            {
                db.Books.Remove(pic);
            }
        }

        public IEnumerable<Book> GetBookByStyleName(string nameStyle)
        {
            Style style = db.Styles.FirstOrDefault(s => s.NameStyle == nameStyle);
            
            //IEnumerable<Book> books = db.Books.Where(b=> b.Genre)
            return null;
        }

        public IEnumerable<Book> GetBookByGenreName(string nameGenre)
        {
            Genre genre = db.Genres.FirstOrDefault(g => g.NameGenre == nameGenre);
            
            IEnumerable<Book> books = db.Books.Where(b => b.GenreID == genre.ID);
            
            return books;
        }

        public int GetId(string title)
        {
            var BookId = db.Books.FirstOrDefault(b => b.Title == title);
            return BookId != null ? BookId.ID : 0;
        }

        public Book GetBookById(int id)
        {
            Book book = db.Books.Find(id);
            db.Entry(book).Reference(b => b.Genre).Load();
            return book;
        }

        //Save changes db
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
