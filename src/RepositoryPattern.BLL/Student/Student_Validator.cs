
using RepositoryPattern.BLL.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryPattern.BLL.Features.Student
{
    public class Student_Validator
    {
        public static ValidationResultDTO CreateStudent_Validation(StudentDTO StudentDTO)
        {
            var _ValidationResultDTO = new ValidationResultDTO
            {
                Description = "The record has been validated successfully.."
            };
            try
            {
                var _validation_ResultList = new List<ValidationResultDTO>();
                
                // Field Validation
                if (string.IsNullOrEmpty(StudentDTO.Name))
                {
                    _validation_ResultList.Add(new ValidationResultDTO
                    {
                        Result = false, 
                        Message = "Name Field Empty", 
                        Description = " Please, complete the missing information ", 
                    });
                }
                if (StudentDTO.Grade<0 || StudentDTO.Grade >100)
                {
                    _validation_ResultList.Add(new ValidationResultDTO
                    {
                        Result = false, 
                        Message = "Grade Invalid ", 
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
        public static ValidationResultDTO UpdateStudent_Validation(StudentDTO StudentDTO)
        {
            var _ValidationResultDTO = new ValidationResultDTO
            {
                Description = "The record has been validated successfully.."
            };
            try
            {
                var _validation_ResultList = new List<ValidationResultDTO>();
                
                // Field Validation
                if (StudentDTO.ID == null || StudentDTO.ID == 0)
                {
                    _validation_ResultList.Add(new ValidationResultDTO
                    {
                        Result = false,
                        Message = "ID Field Empty",
                        Description = "Please, complete the missing information ",
                    });
                }
                if (string.IsNullOrEmpty(StudentDTO.Name))
                {
                    _validation_ResultList.Add(new ValidationResultDTO
                    {
                        Result = false, 
                        Message = "Name Field Empty", 
                        Description = " Please, complete the missing information ", 
                    });
                }
                if (StudentDTO.Grade < 0 || StudentDTO.Grade > 100)
                {
                    _validation_ResultList.Add(new ValidationResultDTO
                    {
                        Result = false,
                        Message = "Grade Invalid ",
                        Description = " Please, complete the missing information ",
                    });
                }

                if (StudentDTO.LastUpdateByID == null || StudentDTO.LastUpdateByID == 0)
                {
                    _validation_ResultList.Add(new ValidationResultDTO
                    {
                        Result = false,
                        Message = "LastUpdateByID Field Empty",
                        Description = "Please, complete the missing information ",
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
        public static ValidationResultDTO DeleteStudent_Validation(StudentDTO StudentDTO)
        {
            var _ValidationResultDTO = new ValidationResultDTO
            {
                Description = "The record has been validated successfully.."
            };
            try
            {
                var _validation_ResultList = new List<ValidationResultDTO>();
                
                // Field Validation
                if (StudentDTO.ID == null || StudentDTO.ID == 0)
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
