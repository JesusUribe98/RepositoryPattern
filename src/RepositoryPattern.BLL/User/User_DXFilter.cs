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
            var _groupOperator = new GroupOperator();
            try
            {
                if (UserDTO.ID > 0 || UserDTO.ID != null )
               {
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
