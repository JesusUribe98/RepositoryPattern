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
            //Generar filtros antes de realizar la consulta en la base de datos
            var _groupOperator = new GroupOperator();
            try
            {
                //Verificar si se envio un valor ID para filtrar
                if (StudentDTO.ID > 0 || StudentDTO.ID != null )
               {
                    //Filtrar por ID
                    _groupOperator.Operands.Add(new BinaryOperator(nameof(StudentXPO.Oid), StudentDTO.ID));
               }
                //Verificar si se envio un valor Pass para filtrar
                if (StudentDTO.Pass != null)
               {
                    //Filtar por aprobacion
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
