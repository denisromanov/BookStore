using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BookDB;
using BookDB.Abstract;
using BookDB.Entities;

namespace Book.API.Controllers
{
    public class BookController : ApiController
    {
        private IBookRepository<BookDB.Entities.Book> dbRepository;
    
        public BookController()
        {
            dbRepository = new BookRepository();
        }

        // GET api/<controller>
        public IEnumerable<BookDB.Entities.Book> GetAllBooks()
        {
            return dbRepository.GetAll();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}