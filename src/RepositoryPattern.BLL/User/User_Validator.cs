
using RepositoryPattern.BLL.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryPattern.BLL.Features.User
{
    public class User_Validator
    {
        public static ValidationResultDTO CreateUser_Validation(UserDTO UserDTO)
        {
            var _ValidationResultDTO = new ValidationResultDTO
            {
                Description = "The record has been validated successfully.."
            };
            try
            {
                var _validation_ResultList = new List<ValidationResultDTO>();
                
                // Field Validation
                if (string.IsNullOrEmpty(UserDTO.UserName))
                {
                    _validation_ResultList.Add(new ValidationResultDTO
                    {
                        Result = false, 
                        Message = "UserName Field Empty", 
                        Description = " Please, complete the missing information ", 
                    });
                }
                if (string.IsNullOrEmpty(UserDTO.Email))
                {
                    _validation_ResultList.Add(new ValidationResultDTO
                    {
                        Result = false, 
                        Message = "Email Field Empty", 
                        Description = " Please, complete the missing information ", 
                    });
                }
                
                
                // if list contains a error, update main validation result
                if (_validation_ResultList.Count > 0)
                {
                    _ValidationResultDTO.Result = false;
                    _ValidationResultDTO.Message = "Errors!";
                    _ValidationResultDTO.Description = "There is a list of errors";
                    _ValidationResultDTO.Validation_ResultList = _validation_ResultList;

                }
            }
            catch (Exception ex)
            {
                _ValidationResultDTO.Result = false;
                _ValidationResultDTO.Message = "Error!";
                _ValidationResultDTO.Description = string.Format("There was an error trying to validate the fields. {0}", ex.Message);
            }
            return _ValidationResultDTO;
        }
        public static ValidationResultDTO UpdateUser_Validation(UserDTO UserDTO)
        {
            var _ValidationResultDTO = new ValidationResultDTO
            {
                Description = "The record has been validated successfully.."
            };
            try
            {
                var _validation_ResultList = new List<ValidationResultDTO>();
                
                // Field Validation
                if (UserDTO.ID == null || UserDTO.ID == 0)
                {
                    _validation_ResultList.Add(new ValidationResultDTO
                    {
                        Result = false,
                        Message = "ID Field Empty",
                        Description = "Please, complete the missing information ",
                    });
                }
                if (string.IsNullOrEmpty(UserDTO.UserName))
                {
                    _validation_ResultList.Add(new ValidationResultDTO
                    {
                        Result = false, 
                        Message = "UserName Field Empty", 
                        Description = " Please, complete the missing information ", 
                    });
                }
                if (string.IsNullOrEmpty(UserDTO.Email))
                {
                    _validation_ResultList.Add(new ValidationResultDTO
                    {
                        Result = false, 
                        Message = "Email Field Empty", 
                        Description = " Please, complete the missing information ", 
                    });
                }
                
                

                // if list contains a error, update main validation result
                if (_validation_ResultList.Count > 0)
                {
                    _ValidationResultDTO.Result = false;
                    _ValidationResultDTO.Message = "Errors!";
                    _ValidationResultDTO.Description = "There is a list of errors";
                    _ValidationResultDTO.Validation_ResultList = _validation_ResultList;

                }
            }
            catch (Exception ex)
            {
                _ValidationResultDTO.Result = false;
                _ValidationResultDTO.Message = "Error!";
                _ValidationResultDTO.Description = string.Format("There was an error trying to validate the fields. {0}", ex.Message);
            }
            return _ValidationResultDTO;
        }
        public static ValidationResultDTO DeleteUser_Validation(UserDTO UserDTO)
        {
            var _ValidationResultDTO = new ValidationResultDTO
            {
                Description = "The record has been validated successfully.."
            };
            try
            {
                var _validation_ResultList = new List<ValidationResultDTO>();
                
                // Field Validation
                if (UserDTO.ID == null || UserDTO.ID == 0)
                {
                    _validation_ResultList.Add(new ValidationResultDTO
                    {
                        Result = false,
                        Message = "ID Field Empty",
                        Description = " Please, complete the missing information ",
                    });
                }

                // if list contains a error, update main validation result
                if (_validation_ResultList.Count > 0)
                {
                    _ValidationResultDTO.Result = false;
                    _ValidationResultDTO.Message = "Errors!";
                    _ValidationResultDTO.Description = "There is a list of errors";
                    _ValidationResultDTO.Validation_ResultList = _validation_ResultList;

                }
            }
            catch (Exception ex)
            {
                _ValidationResultDTO.Result = false;
                _ValidationResultDTO.Message = "Error!";
                _ValidationResultDTO.Description = string.Format("There was an error trying to validate the fields. {0}", ex.Message);
            }
            return _ValidationResultDTO;
        }
   
    }
}
