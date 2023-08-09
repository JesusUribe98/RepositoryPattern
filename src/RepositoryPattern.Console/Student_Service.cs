using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Console
{
    public class Student_Service
    {

        #region CRUD
        public static string CreateStudent(Student Student)
        {
            var _result = string.Empty;
            //validation
            _result = CreateStudent_validation(Student);
            if (_result.Contains("success"))
            {
                //Business Logic
                if (Student.Grade > 70)
                {
                    Student.Pass = true;
                }
                else
                {
                    Student.Pass = false;
                }

                _result = Student_Repository.Create(Student);
            }
            return _result;

        }
        public static string UpdateStudent(Student Student)
        {
            var _result = string.Empty;
            //Validation
            _result = UpdateStudent_validation(Student);
            if (_result.Contains("success"))
            {
                //Business Logic
                if (Student.Grade > 70)
                {
                    Student.Pass = true;
                }
                else
                {
                    Student.Pass = false;
                }
                _result = Student_Repository.Update(Student);
            }
            return _result;
        }

        public static string DeleteStudent(Student Student)
        {
            var _result = string.Empty;
            //Validation
            _result = DeleteStudent_Validation(Student);
            if (_result.Contains("success"))
            {
                //Business Logic
                _result = Student_Repository.Delete(Student);
            }

            return _result;
        }

        public static List<Student> GetStudents(Student Student)
        {
            var _result = Student_Repository.Get(Student);
            return _result;
        }
        #endregion


        #region Validations
        public static string CreateStudent_validation(Student Student)
        {
            var _result = "Validation success";

            //validations
            if (string.IsNullOrEmpty(Student.Name))
            {
                _result= "Error : Name is empty";
            }
            if (Student.Grade < 0 || Student.Grade > 100)
            {
                _result= "Error : Grade is invalid";
            }
            return _result;
        }

        public static string UpdateStudent_validation(Student Student)
        {
            var _result = "Validation success";

            //validations
            if (Student.ID == null || Student.ID == 0)
            {
                _result = "Error: ID is empty";
            }
            else
            {
                var _studentObj = Student_Repository.Get(Student).FirstOrDefault();
                if (_studentObj == null)
                {
                    _result = "Error: User dont exist";
                }
            }                        
            if (string.IsNullOrEmpty(Student.Name))
            {
                _result = "Error: Name is empty";
            }
            if (Student.Grade < 0 || Student.Grade > 100)
            {
                _result = "Error: Grade is invalid";
            }
            return _result;
        }

        public static string DeleteStudent_Validation(Student Student)
        {
            var _result = "Validation success";

            //validations
            if (Student.ID == null || Student.ID == 0)
            {
                _result = "Error: ID is empty";
            }
            else
            {
                var _studentObj = Student_Repository.Get(Student).FirstOrDefault();
                if (_studentObj == null)
                {
                    _result = "Error: User dont exist";
                }
            }
           
            return _result;
        }
        #endregion

    }
}
