using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApp_School_Api_CRUD.Models;

namespace WebApp_School_Api_CRUD.Controllers
{
    public class BookController : ApiController
    {
        private StudentOparations studentOperations;

        public BookController()
        {
            studentOperations = new StudentOparations();
        }
        public List<BooksData> Get()
        {
            return studentOperations.GetBook();
        }
        public BooksData Get(int id)
        {
            return studentOperations.GetBookSigle(id);
        }
        public void Post([FromBody] BooksData B)
        {
            studentOperations.InsertBook(B);
        }
        public void Put([FromBody] BooksData B)
        {
            studentOperations.UpdateBook(B);
        }

        public void Delete(int id)
        {
            studentOperations.DeleteBook(id);
        }
    }
}
