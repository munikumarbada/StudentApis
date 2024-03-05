using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApp_School_Api_CRUD.Models;

namespace WebApp_School_Api_CRUD.Controllers
{
    public class LibraryController : ApiController
    {
        private StudentOparations studentOperations;

        public LibraryController()
        {
            studentOperations = new StudentOparations();
        }
        public List<LibraryData> Get()
        {
            return studentOperations.GetLibrary();
        }
        public LibraryData Get(int id)
        {
            return studentOperations.GetLibrarySingle(id);
        }
        public void Post([FromBody] LibraryData l)
        {
            studentOperations.InsertLibrary(l);
        }
        public void Put([FromBody] LibraryData l)
        {
            studentOperations.UpdateLibrary(l);
        }

        public void Delete(int id)
        {
            studentOperations.DeleteLibrary(id);
        }
    }
}
