using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookDB.Entities;

namespace BookDB.Abstract
{
    public interface IBookRepository<Book>
    {
        IEnumerable<Book> GetAll();
        void Create(Book book);
        void Update(Book book);
        void Delete(int id);
        Book GetBookById(int id);
        IEnumerable<Book> GetBookByStyleName(string nameStyle);
        IEnumerable<Book> GetBookByGenreName(string nameGenre);
        int GetId(string name);
        void Save();
    }
}
