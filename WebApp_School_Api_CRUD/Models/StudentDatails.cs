using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;


namespace WebApp_School_Api_CRUD.Models
{
    public class StudentDatails
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Class { get; set; }
        public byte[] Photo { get; set; }
        public byte[] Video { get; set; }
    }
    public class LibraryData
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string BookName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
    public class BooksData
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Publication { get; set; }
        public DateTime Year { get; set; }
    }    
    
    public class StudentOparations
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
        SqlCommand cmd;
        SqlParameter sp;
        StudentDatails sData=new StudentDatails();
        BooksData bData = new BooksData();
        LibraryData lData = new LibraryData();
        public string OperationType { get; set; }
        
        public List<StudentDatails> GetStudent()
        {
            OperationType = "Student";
            List<StudentDatails> StudentList = new List<StudentDatails>();
            cmd = new SqlCommand("SchoolCRUD", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OperationType", OperationType);
            cmd.Parameters.AddWithValue("@StudentId", null);
            cmd.Parameters.AddWithValue("@StudentName", null);
            cmd.Parameters.AddWithValue("@Class", null);
            cmd.Parameters.AddWithValue("@Photo", null);
            cmd.Parameters.AddWithValue("@Video", null);
            cmd.Parameters.AddWithValue("@BookId", null);
            cmd.Parameters.AddWithValue("@BookName", null);
            cmd.Parameters.AddWithValue("@Author", null);
            cmd.Parameters.AddWithValue("@Publication", null);
            cmd.Parameters.AddWithValue("@Year", null);
            cmd.Parameters.AddWithValue("@LibraryId", null);
            cmd.Parameters.AddWithValue("@StartDate", null);
            cmd.Parameters.AddWithValue("@EndDate", null);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                StudentDatails p = new StudentDatails();
                p.StudentId = Convert.ToInt32(dr[0]);
                p.StudentName = dr[1].ToString();
                p.Class = dr[2].ToString();
                p.Photo = (byte[]) dr[3];
                p.Video = (byte[])dr[4];
                StudentList.Add(p);
            }
            con.Close();
            return StudentList;
        }
        public List<BooksData> GetBook()
        {
            OperationType = "Book";
            List<BooksData> BookList = new List<BooksData>();
            cmd = new SqlCommand("SchoolCRUD", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OperationType", OperationType);
            cmd.Parameters.AddWithValue("@StudentId", null);
            cmd.Parameters.AddWithValue("@StudentName", null);
            cmd.Parameters.AddWithValue("@Class", null);
            cmd.Parameters.AddWithValue("@Photo", null);
            cmd.Parameters.AddWithValue("@Video", null);
            cmd.Parameters.AddWithValue("@BookId", null);
            cmd.Parameters.AddWithValue("@BookName", null);
            cmd.Parameters.AddWithValue("@Author", null);
            cmd.Parameters.AddWithValue("@Publication", null);
            cmd.Parameters.AddWithValue("@Year", null);
            cmd.Parameters.AddWithValue("@LibraryId", null);
            cmd.Parameters.AddWithValue("@StartDate", null);
            cmd.Parameters.AddWithValue("@EndDate", null);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                BooksData p = new BooksData();
                p.BookId = Convert.ToInt32(dr[0]);
                p.BookName = dr[1].ToString();
                p.Author = dr[2].ToString();
                p.Publication = dr[3].ToString();
                p.Year =Convert.ToDateTime(dr[4]);
                BookList.Add(p);
            }
            con.Close();
            return BookList;
        }
        public List<LibraryData> GetLibrary()
        {
            OperationType = "Library";
            List<LibraryData> LibraryList = new List<LibraryData>();
            cmd = new SqlCommand("SchoolCRUD", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OperationType", OperationType);
            cmd.Parameters.AddWithValue("@StudentId", null);
            cmd.Parameters.AddWithValue("@StudentName", null);
            cmd.Parameters.AddWithValue("@Class", null);
            cmd.Parameters.AddWithValue("@Photo", null);
            cmd.Parameters.AddWithValue("@Video", null);
            cmd.Parameters.AddWithValue("@BookId", null);
            cmd.Parameters.AddWithValue("@BookName", null);
            cmd.Parameters.AddWithValue("@Author", null);
            cmd.Parameters.AddWithValue("@Publication", null);
            cmd.Parameters.AddWithValue("@Year", null);
            cmd.Parameters.AddWithValue("@LibraryId", null);
            cmd.Parameters.AddWithValue("@StartDate", null);
            cmd.Parameters.AddWithValue("@EndDate", null);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LibraryData p = new LibraryData();
                p.Id = Convert.ToInt32(dr[0]);
                p.StudentName = dr[1].ToString();
                p.BookName = dr[2].ToString();
                p.StartDate =Convert.ToDateTime(dr[3]);
                p.EndDate = Convert.ToDateTime(dr[4]);
                LibraryList.Add(p);
            }
            con.Close();
            return LibraryList;
        }
        public StudentDatails GetStudentSigle(int id)
        {
            OperationType = "find";
            cmd = new SqlCommand("SchoolCRUD", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OperationType", OperationType);
            cmd.Parameters.AddWithValue("@StudentId", id);
            cmd.Parameters.AddWithValue("@StudentName", null);
            cmd.Parameters.AddWithValue("@Class", null);
            cmd.Parameters.AddWithValue("@Photo", null);
            cmd.Parameters.AddWithValue("@Video", null);
            cmd.Parameters.AddWithValue("@BookId", null);
            cmd.Parameters.AddWithValue("@BookName", null);
            cmd.Parameters.AddWithValue("@Author", null);
            cmd.Parameters.AddWithValue("@Publication", null);
            cmd.Parameters.AddWithValue("@Year", null);
            cmd.Parameters.AddWithValue("@LibraryId", null);
            cmd.Parameters.AddWithValue("@StartDate", null);
            cmd.Parameters.AddWithValue("@EndDate", null);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            StudentDatails p = null;
            while (dr.Read())
            {
                p = new StudentDatails();
                p.StudentId = Convert.ToInt32(dr[0]);
                p.StudentName = dr[1].ToString();
                p.Class = dr[2].ToString();
                p.Photo = (byte[])dr[3];
                p.Video = (byte[])dr[4];               
            }
            con.Close();
            return p;
        }
        public BooksData GetBookSigle(int id)
        {
            OperationType = "find";
            cmd = new SqlCommand("SchoolCRUD", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OperationType", OperationType);
            cmd.Parameters.AddWithValue("@StudentId", null);
            cmd.Parameters.AddWithValue("@StudentName", null);
            cmd.Parameters.AddWithValue("@Class", null);
            cmd.Parameters.AddWithValue("@Photo", null);
            cmd.Parameters.AddWithValue("@Video", null);
            cmd.Parameters.AddWithValue("@BookId", id);
            cmd.Parameters.AddWithValue("@BookName", null);
            cmd.Parameters.AddWithValue("@Author", null);
            cmd.Parameters.AddWithValue("@Publication", null);
            cmd.Parameters.AddWithValue("@Year", null);
            cmd.Parameters.AddWithValue("@LibraryId", null);
            cmd.Parameters.AddWithValue("@StartDate", null);
            cmd.Parameters.AddWithValue("@EndDate", null);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            BooksData p = null;
            while (dr.Read())
            {
                p = new BooksData();
                p.BookId = Convert.ToInt32(dr[0]);
                p.BookName = dr[1].ToString();
                p.Author = dr[2].ToString();
                p.Publication = dr[3].ToString();
                p.Year = Convert.ToDateTime(dr[4]);
            }
            con.Close();
            return p;
        }
        public LibraryData GetLibrarySingle(int id)
        {
            OperationType = "find";
            cmd = new SqlCommand("SchoolCRUD", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OperationType", OperationType);
            cmd.Parameters.AddWithValue("@StudentId", null);
            cmd.Parameters.AddWithValue("@StudentName", null);
            cmd.Parameters.AddWithValue("@Class", null);
            cmd.Parameters.AddWithValue("@Photo", null);
            cmd.Parameters.AddWithValue("@Video", null);
            cmd.Parameters.AddWithValue("@BookId", null);
            cmd.Parameters.AddWithValue("@BookName", null);
            cmd.Parameters.AddWithValue("@Author", null);
            cmd.Parameters.AddWithValue("@Publication", null);
            cmd.Parameters.AddWithValue("@Year", null);
            cmd.Parameters.AddWithValue("@LibraryId", id);
            cmd.Parameters.AddWithValue("@StartDate", null);
            cmd.Parameters.AddWithValue("@EndDate", null);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            LibraryData p = null;
            while (dr.Read())
            {
                p = new LibraryData();
                p.Id = Convert.ToInt32(dr[0]);
                p.StudentName = dr[1].ToString();
                p.BookName = dr[2].ToString();
                p.StartDate =Convert.ToDateTime(dr[3]);
                p.EndDate = Convert.ToDateTime(dr[4]);
            }
            con.Close();
            return p;
        }

        public int InsertStudent(StudentDatails S)
        {
            OperationType = "insert";
            cmd = new SqlCommand("SchoolCRUD", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OperationType", OperationType);
            cmd.Parameters.AddWithValue("@StudentId", S.StudentId);
            cmd.Parameters.AddWithValue("@StudentName", S.StudentName);
            cmd.Parameters.AddWithValue("@Class", S.Class);
            cmd.Parameters.AddWithValue("@Photo", S.Photo);
            cmd.Parameters.AddWithValue("@Video", S.Video);
            cmd.Parameters.AddWithValue("@BookId", null);
            cmd.Parameters.AddWithValue("@BookName", null);
            cmd.Parameters.AddWithValue("@Author", null);
            cmd.Parameters.AddWithValue("@Publication", null);
            cmd.Parameters.AddWithValue("@Year", null);
            cmd.Parameters.AddWithValue("@LibraryId",null);
            cmd.Parameters.AddWithValue("@StartDate", null);
            cmd.Parameters.AddWithValue("@EndDate", null);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public int InsertBook(BooksData B)
        {
            OperationType = "insert";
            cmd = new SqlCommand("SchoolCRUD", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OperationType", OperationType);
            cmd.Parameters.AddWithValue("@StudentId", null);
            cmd.Parameters.AddWithValue("@StudentName", null);
            cmd.Parameters.AddWithValue("@Class", null);
            cmd.Parameters.AddWithValue("@Photo", null);
            cmd.Parameters.AddWithValue("@Video", null);
            cmd.Parameters.AddWithValue("@BookId", B.BookId);
            cmd.Parameters.AddWithValue("@BookName", B.BookName);
            cmd.Parameters.AddWithValue("@Author", B.Author);
            cmd.Parameters.AddWithValue("@Publication", B.Publication);
            cmd.Parameters.AddWithValue("@Year", B.Year);
            cmd.Parameters.AddWithValue("@LibraryId", null);
            cmd.Parameters.AddWithValue("@StartDate", null);
            cmd.Parameters.AddWithValue("@EndDate", null);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public int InsertLibrary(LibraryData l)
        {
            OperationType = "insert";
            cmd = new SqlCommand("SchoolCRUD", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OperationType", OperationType);
            cmd.Parameters.AddWithValue("@StudentId", null);
            cmd.Parameters.AddWithValue("@StudentName", l.StudentName);
            cmd.Parameters.AddWithValue("@Class", null);
            cmd.Parameters.AddWithValue("@Photo", null);
            cmd.Parameters.AddWithValue("@Video", null);
            cmd.Parameters.AddWithValue("@BookId", null);
            cmd.Parameters.AddWithValue("@BookName", l.BookName);
            cmd.Parameters.AddWithValue("@Author", null);
            cmd.Parameters.AddWithValue("@Publication", null);
            cmd.Parameters.AddWithValue("@Year", null);
            cmd.Parameters.AddWithValue("@LibraryId", l.Id);
            cmd.Parameters.AddWithValue("@StartDate", l.StartDate);
            cmd.Parameters.AddWithValue("@EndDate", l.EndDate);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public int UpdateStudent(StudentDatails S)
        {
            OperationType = "Update";
            cmd = new SqlCommand("SchoolCRUD", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OperationType", OperationType);
            cmd.Parameters.AddWithValue("@StudentId", S.StudentId);
            cmd.Parameters.AddWithValue("@StudentName", S.StudentName);
            cmd.Parameters.AddWithValue("@Class", S.Class);
            cmd.Parameters.AddWithValue("@Photo", S.Photo);
            cmd.Parameters.AddWithValue("@Video", S.Video);
            cmd.Parameters.AddWithValue("@BookId", null);
            cmd.Parameters.AddWithValue("@BookName", null);
            cmd.Parameters.AddWithValue("@Author", null);
            cmd.Parameters.AddWithValue("@Publication", null);
            cmd.Parameters.AddWithValue("@Year", null);
            cmd.Parameters.AddWithValue("@LibraryId", null);
            cmd.Parameters.AddWithValue("@StartDate", null);
            cmd.Parameters.AddWithValue("@EndDate", null);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public int UpdateStudentPhoto(StudentDatails S)
        {
            OperationType = "Update";
            cmd = new SqlCommand("SchoolCRUD", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OperationType", OperationType);
            cmd.Parameters.AddWithValue("@StudentId", S.StudentId);
            cmd.Parameters.AddWithValue("@StudentName", S.StudentName);
            cmd.Parameters.AddWithValue("@Class", S.Class);
            cmd.Parameters.AddWithValue("@Photo", null);
            cmd.Parameters.AddWithValue("@Video", null);
            cmd.Parameters.AddWithValue("@BookId", null);
            cmd.Parameters.AddWithValue("@BookName", null);
            cmd.Parameters.AddWithValue("@Author", null);
            cmd.Parameters.AddWithValue("@Publication", null);
            cmd.Parameters.AddWithValue("@Year", null);
            cmd.Parameters.AddWithValue("@LibraryId", null);
            cmd.Parameters.AddWithValue("@StartDate", null);
            cmd.Parameters.AddWithValue("@EndDate", null);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public int UpdateBook(BooksData B)
        {
            OperationType = "Update";
            cmd = new SqlCommand("SchoolCRUD", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OperationType", OperationType);
            cmd.Parameters.AddWithValue("@StudentId", null);
            cmd.Parameters.AddWithValue("@StudentName", null);
            cmd.Parameters.AddWithValue("@Class", null);
            cmd.Parameters.AddWithValue("@Photo", null);
            cmd.Parameters.AddWithValue("@Video", null);
            cmd.Parameters.AddWithValue("@BookId", B.BookId);
            cmd.Parameters.AddWithValue("@BookName", B.BookName);
            cmd.Parameters.AddWithValue("@Author", B.Author);
            cmd.Parameters.AddWithValue("@Publication", B.Publication);
            cmd.Parameters.AddWithValue("@Year", B.Year);
            cmd.Parameters.AddWithValue("@LibraryId", null);
            cmd.Parameters.AddWithValue("@StartDate", null);
            cmd.Parameters.AddWithValue("@EndDate", null);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public int UpdateLibrary(LibraryData l)
        {
            OperationType = "Update";
            cmd = new SqlCommand("SchoolCRUD", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OperationType", OperationType);
            cmd.Parameters.AddWithValue("@StudentId", null);
            cmd.Parameters.AddWithValue("@StudentName", l.StudentName);
            cmd.Parameters.AddWithValue("@Class", null);
            cmd.Parameters.AddWithValue("@Photo", null);
            cmd.Parameters.AddWithValue("@Video", null);
            cmd.Parameters.AddWithValue("@BookId", null);
            cmd.Parameters.AddWithValue("@BookName", l.BookName);
            cmd.Parameters.AddWithValue("@Author", null);
            cmd.Parameters.AddWithValue("@Publication", null);
            cmd.Parameters.AddWithValue("@Year", null);
            cmd.Parameters.AddWithValue("@LibraryId", l.Id);
            cmd.Parameters.AddWithValue("@StartDate", l.StartDate);
            cmd.Parameters.AddWithValue("@EndDate", l.EndDate);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public int DeleteStudent(int id)
        {
            OperationType = "Delete";
            cmd = new SqlCommand("SchoolCRUD", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OperationType", OperationType);
            cmd.Parameters.AddWithValue("@StudentId", id);
            cmd.Parameters.AddWithValue("@StudentName", null);
            cmd.Parameters.AddWithValue("@Class", null);
            cmd.Parameters.AddWithValue("@Photo", null);
            cmd.Parameters.AddWithValue("@Video", null);
            cmd.Parameters.AddWithValue("@BookId", null);
            cmd.Parameters.AddWithValue("@BookName", null);
            cmd.Parameters.AddWithValue("@Author", null);
            cmd.Parameters.AddWithValue("@Publication", null);
            cmd.Parameters.AddWithValue("@Year", null);
            cmd.Parameters.AddWithValue("@LibraryId", null);
            cmd.Parameters.AddWithValue("@StartDate", null);
            cmd.Parameters.AddWithValue("@EndDate", null);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public int DeleteBook(int id)
        {
            OperationType = "Delete";
            cmd = new SqlCommand("SchoolCRUD", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OperationType", OperationType);
            cmd.Parameters.AddWithValue("@StudentId", null);
            cmd.Parameters.AddWithValue("@StudentName", null);
            cmd.Parameters.AddWithValue("@Class", null);
            cmd.Parameters.AddWithValue("@Photo", null);
            cmd.Parameters.AddWithValue("@Video", null);
            cmd.Parameters.AddWithValue("@BookId", id);
            cmd.Parameters.AddWithValue("@BookName", null);
            cmd.Parameters.AddWithValue("@Author", null);
            cmd.Parameters.AddWithValue("@Publication", null);
            cmd.Parameters.AddWithValue("@Year", null);
            cmd.Parameters.AddWithValue("@LibraryId", null);
            cmd.Parameters.AddWithValue("@StartDate", null);
            cmd.Parameters.AddWithValue("@EndDate", null);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public int DeleteLibrary(int id)
        {
            OperationType = "Delete";
            cmd = new SqlCommand("SchoolCRUD", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OperationType", OperationType);
            cmd.Parameters.AddWithValue("@StudentId", id);
            cmd.Parameters.AddWithValue("@StudentName", null);
            cmd.Parameters.AddWithValue("@Class", null);
            cmd.Parameters.AddWithValue("@Photo", null);
            cmd.Parameters.AddWithValue("@Video", null);
            cmd.Parameters.AddWithValue("@BookId", null);
            cmd.Parameters.AddWithValue("@BookName", null);
            cmd.Parameters.AddWithValue("@Author", null);
            cmd.Parameters.AddWithValue("@Publication", null);
            cmd.Parameters.AddWithValue("@Year", null);
            cmd.Parameters.AddWithValue("@LibraryId", id);
            cmd.Parameters.AddWithValue("@StartDate", null);
            cmd.Parameters.AddWithValue("@EndDate", null);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}