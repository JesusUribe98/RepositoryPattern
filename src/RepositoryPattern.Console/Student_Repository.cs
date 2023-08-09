using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Console
{
    public class Student_Repository
    {
        //Datasource 
        private static List<Student> _studentsList_Global = new List<Student>();

        //Create or add
        public static string Create(Student Student)
        {
            _studentsList_Global.Add(Student);
            return "Student was added";
        }
        //Update
        public static string Update(Student Student)
        {
            var _studentByID = _studentsList_Global.FirstOrDefault(studentItem => studentItem.ID == Student.ID);
            _studentByID.Name = Student.Name;
            _studentByID.Grade = Student.Grade;
            _studentByID.Pass = Student.Pass;

            return "Student was update";
        }
        //Delete
        public static string Delete(Student Student)
        {

            _studentsList_Global.Remove(Student);
            return "Student was delete";
        }


        //Get
        public static List<Student> Get(Student Student)
        {
            var _studentList = new List<Student>();
            //Filtro
            if (Student.ID != null && Student.ID > 0)
            {
                _studentList = _studentsList_Global.Where(studentItem => studentItem.ID == Student.ID).ToList();
                return _studentList;
            }
            //Si no hay filtro retornar toda la lista
            _studentList = _studentsList_Global;
            return _studentList;
        }


    }
}
