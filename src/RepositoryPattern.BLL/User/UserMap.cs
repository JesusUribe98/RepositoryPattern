using DevExpress.Xpo;
using RepositoryPattern.DAL.XPO.RepositoryPattern;
using System;

namespace RepositoryPattern.BLL.Features.User
{
    public class UserMap
    {
        //Funcion para mapear objetos de tipo XPO a DTO
        public static UserDTO XPOToDTO(UserXPO UserXPO)
        {
            var _userDTO = new UserDTO();
            try
            {
                _userDTO.ID = UserXPO.Oid;
               _userDTO.UserName = UserXPO.UserName; 
               _userDTO.Email = UserXPO.Email; 
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _userDTO;
        }
        //Funcion para mapear objetos de tipo DTO a XPO
        public static UserXPO DTOtoXPO(UserDTO UserDTO, UnitOfWork UnitOfWork)
        {
            UserXPO _userXPO;
            try
            {
                _userXPO = UserDTO.ID == null ? new UserXPO(UnitOfWork) : UnitOfWork.GetObjectByKey<UserXPO>(UserDTO.ID);
                _userXPO.UserName = _userXPO.UserName == UserDTO.UserName ? _userXPO.UserName : UserDTO.UserName;
               _userXPO.Email = _userXPO.Email == UserDTO.Email ? _userXPO.Email : UserDTO.Email;
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _userXPO;
        }

    }
}
