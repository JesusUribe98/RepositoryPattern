using System;
using System.Linq;
using DevExpress.Data.Filtering;
using RepositoryPattern.DAL.XPO.RepositoryPattern;

namespace RepositoryPattern.BLL.Features.Student
{
    public class Student_Filter
    {
       public static GroupOperator GetStudentFilters(StudentDTO StudentDTO)
        {
            var _groupOperator = new GroupOperator();
            try
            {
                if (StudentDTO.ID > 0 || StudentDTO.ID != null )
               {
                    _groupOperator.Operands.Add(new BinaryOperator(nameof(StudentXPO.Oid), StudentDTO.ID));
               }
               
               if (StudentDTO.Pass != null)
               {
                    _groupOperator.Operands.Add(new BinaryOperator(nameof(StudentXPO.Pass), StudentDTO.Pass));
               }
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _groupOperator;
        }
    }
}
