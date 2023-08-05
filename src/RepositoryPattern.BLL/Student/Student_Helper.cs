
using System;
using System.Collections.Generic;
using System.Linq;
using RepositoryPattern.BLL.Common;

namespace RepositoryPattern.BLL.Features.Student
{
    public class Student_Helper
    {
        #region Global CRUD
        public static ValidationResultDTO CreateStudent_Global(StudentDTO StudentDTO)
        {
            var _validationResultDTO = Student_Validator.CreateStudent_Validation(StudentDTO);
            if (_validationResultDTO.Result)
            {
                if(StudentDTO.Grade > 70)
                {
                    StudentDTO.Pass = true;
                }
                else
                {
                    StudentDTO.Pass = false;
                }

                _validationResultDTO = Student_Repository.CreateStudent(StudentDTO);
            }
            return _validationResultDTO;
        }
        public static ValidationResultDTO UpdateStudent_Global(StudentDTO StudentDTO)
        {
            var _validationResultDTO = Student_Validator.UpdateStudent_Validation(StudentDTO);
            if (_validationResultDTO.Result)
            {
                if (StudentDTO.Grade > 70)
                {
                    StudentDTO.Pass = true;
                }
                else
                {
                    StudentDTO.Pass = false;
                }
                _validationResultDTO = Student_Repository.UpdateStudent(StudentDTO);
            }
            return _validationResultDTO;
        }
        public static ValidationResultDTO DeleteStudent_Global(StudentDTO StudentDTO)
        {
            var _validationResultDTO = Student_Validator.DeleteStudent_Validation(StudentDTO);
            if (_validationResultDTO.Result)
            {
                _validationResultDTO = Student_Repository.DeleteStudent(StudentDTO);
            }
            return _validationResultDTO;
        }
        public static List<StudentDTO> GetStudentList_Global(StudentDTO StudentDTO)
        {
            var _studentglobalList = new List<StudentDTO>();
            try
            {
                 _studentglobalList = Student_Repository.GetStudentList(StudentDTO);
                
            }
            catch (Exception ex)
            {
            }
            return _studentglobalList;
        }
        #endregion

    }
}
