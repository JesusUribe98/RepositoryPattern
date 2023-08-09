using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Console
{
    public interface IStudent_Repository
    {
        List<Student> Get();
        string Create(Student student);
        string Update(Student student);
        string Delete(Student student);
    }
}
