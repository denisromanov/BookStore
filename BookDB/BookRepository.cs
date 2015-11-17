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

        //Get Id a Book
        public int GetId(string title)
        {
            var BookId = db.Books.FirstOrDefault(b => b.Title == title);
            return BookId != null ? BookId.ID : 0;
        }

        public Book GetBook(int id)
        {
            Book book = db.Books.Find(id);
            db.Entry(book).Reference(b => b.Genre).Load();
            return book;

            //return db.Books.FirstOrDefault(b => b.ID == id);
        }

        //Save changes db
        public void Save()
        {
            db.SaveChanges();
        }

        //public void GetGenre(int id)
        //{
            
        //}
    }
}
