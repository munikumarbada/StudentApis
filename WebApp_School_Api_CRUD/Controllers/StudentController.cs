using System.Collections.Generic;
using System.Web.Http;
using WebApp_School_Api_CRUD.Models;

namespace WebApp_School_Api_CRUD.Controllers
{
    public class StudentController : ApiController
    {
        private StudentOparations studentOperations;

        public StudentController()
        {
            studentOperations = new StudentOparations();
        }
        public List<StudentDatails> Get()
        {
            return studentOperations.GetStudent();
        }
        public StudentDatails Get(int id)
        {
            return studentOperations.GetStudentSigle(id);
        }
        public void Post([FromBody] StudentDatails student)
        {
            studentOperations.InsertStudent(student);
        }
        public void Put([FromBody] StudentDatails student)
        {
            studentOperations.UpdateStudent(student);
        }       

        public void Delete(int id)
        {
            studentOperations.DeleteStudent(id);
        }
    }
}
