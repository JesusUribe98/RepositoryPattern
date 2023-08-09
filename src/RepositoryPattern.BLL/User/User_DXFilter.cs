using System;
using System.Linq;
using DevExpress.Data.Filtering;
using RepositoryPattern.DAL.XPO.RepositoryPattern;

namespace RepositoryPattern.BLL.Features.User
{
    public class User_Filter
    {
       public static GroupOperator GetUserFilters(UserDTO UserDTO)
        {
            //Generar filtros antes de realizar la consulta en la base de datos
            var _groupOperator = new GroupOperator();
            try
            {
                //Verificar si se envio un valor ID para filtrar
                if (UserDTO.ID > 0 || UserDTO.ID != null )
               {
                    //Filtrar por ID
                    _groupOperator.Operands.Add(new BinaryOperator(nameof(UserXPO.Oid), UserDTO.ID));
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
