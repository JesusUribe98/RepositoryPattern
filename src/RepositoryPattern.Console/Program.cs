namespace RepositoryPattern.Console
{
    public class Program
    {
       public static void Main(string[] args)
        {
            System.Console.WriteLine("Repository Pattern!");

            //declare vars
            string _response;
            List<Student> _studentList;

            //Create student objects
            var _student1 = new Student { ID= 1 , Name="pepito",Grade=80};
            var _student2 = new Student { ID= 2 , Name="miguel",Grade=90};
            var _student3 = new Student { ID= 3 , Name="paco",Grade=50};

            //Add students 
            System.Console.WriteLine("Add students ......");

            _response = Student_Service.CreateStudent(_student1);
            System.Console.WriteLine(_response);

            _response = Student_Service.CreateStudent(_student2);
            System.Console.WriteLine(_response);

            _response = Student_Service.CreateStudent(_student3);
            System.Console.WriteLine(_response);


            //Get students
            System.Console.WriteLine("Get students ......");
            _studentList = Student_Service.GetStudents(new Student { });
            showStudents(_studentList);

            //Update student

            System.Console.WriteLine("Update student ......");
            var _updateStudent = new Student { ID = 5, Name = "chabelo", Grade = 120 };
            _response = Student_Service.UpdateStudent(_updateStudent);
            System.Console.WriteLine(_response);
            
            
            //Get students
            System.Console.WriteLine("Get students ......");
            _studentList = Student_Service.GetStudents(new Student { });
            showStudents(_studentList);


            //Delete 
            System.Console.WriteLine("Delete student ......");
            _response = Student_Service.DeleteStudent(_student3);
            System.Console.WriteLine(_response);


            //Get students
            System.Console.WriteLine("Get students ......");
            _studentList = Student_Service.GetStudents(new Student { });
            showStudents(_studentList);

        }

        public static void showStudents(List<Student> StudentList)
        {
            foreach (Student student in StudentList)
            {

                System.Console.WriteLine($"ID:{student.ID} ,Name:{student.Name},Grade:{student.Grade},Pass:{student.Pass}");
            }
        }
    }
}