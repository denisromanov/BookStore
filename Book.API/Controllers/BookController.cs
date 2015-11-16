using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Book.API.Models;
using BookDB;
using BookDB.Abstract;
using BookDB.Entities;
using Book = BookDB.Entities.Book;
using AutoMapper;

namespace Book.API.Controllers
{
    public class BookController : ApiController
    {
        private IBookRepository<BookDB.Entities.Book> dbRepository;
    
        public BookController()
        {
            Mapper.CreateMap<BookDB.Entities.Book, BookModel>();
            dbRepository = new BookRepository();
        }

        // GET api/<controller>
        public IEnumerable<BookModel> GetAllBooks()
        {
            IEnumerable<BookModel> models = dbRepository.GetAll().Select(b => new BookModel
            {
                Id = b.ID,
                Title = b.Title,
                Price = b.Price,
                PublishYear = b.PublishYear,
                GenreID = b.GenreID,
            });

            return models;
        }

        // GET api/<controller>/5
        public BookModel Get(int id)
        {
            BookModel models = dbRepository.GetAll().Select(b => new BookModel
            {
                Id = b.ID,
                Title = b.Title,
                Price = b.Price,
                PublishYear = b.PublishYear,
                GenreID = b.GenreID,
            }).FirstOrDefault(b => b.Id == id);
            
            return models;
        }

        // POST api/<controller>
        public void Post([FromBody] BookModel bookModel )
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]BookModel bookModel)
        {

        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}