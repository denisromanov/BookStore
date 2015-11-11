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
        Book Read(int id);
        void Update(Book book);
        void Delete(int id);
        int GetId(string name);
        void Save();
    }
}
