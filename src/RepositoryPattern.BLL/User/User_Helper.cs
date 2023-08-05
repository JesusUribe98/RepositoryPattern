
using System;
using System.Collections.Generic;
using System.Linq;
using RepositoryPattern.BLL.Common;

namespace RepositoryPattern.BLL.Features.User
{
    public class User_Helper
    {
        #region Global CRUD
        public static ValidationResultDTO CreateUser_Global(UserDTO UserDTO)
        {
            var _validationResultDTO = User_Validator.CreateUser_Validation(UserDTO);
            if (_validationResultDTO.Result)
            {
                _validationResultDTO = User_Repository.CreateUser(UserDTO);
            }
            return _validationResultDTO;
        }
        public static ValidationResultDTO UpdateUser_Global(UserDTO UserDTO)
        {
            var _validationResultDTO = User_Validator.UpdateUser_Validation(UserDTO);
            if (_validationResultDTO.Result)
            {
                _validationResultDTO = User_Repository.UpdateUser(UserDTO);
            }
            return _validationResultDTO;
        }
        public static ValidationResultDTO DeleteUser_Global(UserDTO UserDTO)
        {
            var _validationResultDTO = User_Validator.DeleteUser_Validation(UserDTO);
            if (_validationResultDTO.Result)
            {
                _validationResultDTO = User_Repository.DeleteUser(UserDTO);
            }
            return _validationResultDTO;
        }
        public static List<UserDTO> GetUserList_Global(UserDTO UserDTO)
        {
            var _userglobalList = new List<UserDTO>();
            try
            {
                 _userglobalList = User_Repository.GetUserList(UserDTO);
                
            }
            catch (Exception ex)
            {

            }
            return _userglobalList;
        }
        #endregion

    }
}
