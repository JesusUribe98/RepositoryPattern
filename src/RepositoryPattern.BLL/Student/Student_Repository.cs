using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using RepositoryPattern.BLL.Common;
using RepositoryPattern.DAL.XPO;
using RepositoryPattern.DAL.XPO.RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryPattern.BLL.Features.Student
{
    public class Student_Repository
    {
        public static List<StudentDTO> GetStudentList(StudentDTO StudentDTO)
        {
            var _studentList = new List<StudentDTO>();
            try
            {
                // Student Filters
                var _groupOperator = Student_Filter.GetStudentFilters(StudentDTO);
                var _sortProperty = new SortProperty();
                

                using (var _session = XPO_Helper.GetNewSession())
                {
                    var _studentCollection = new XPCollection<StudentXPO>(_session, _groupOperator)
                    {

                        Sorting = new SortingCollection(new SortProperty(nameof(StudentXPO.Oid), SortingDirection.Ascending))
                    };

                    if (_studentCollection.AsQueryable().Count() > 0)
                    {
                        _studentList = _studentCollection.Select(StudentXPO => StudentMap.XPOToDTO(StudentXPO)).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
            return _studentList;
        }
        
        public static ValidationResultDTO CreateStudent(StudentDTO StudentDTO)
        {
            var _validationResultDTO = new ValidationResultDTO
            {
                Description = "The record has been saved successfully."
            };
            try
            {
                using (var _unit = XPO_Helper.GetNewUnitOfWork())
                {
                    var _studentXPO = StudentMap.DTOtoXPO(StudentDTO, _unit);
                    _unit.Save(_studentXPO);
                    _unit.CommitChanges();
                }
            }
            catch (Exception ex)
            {
                
                _validationResultDTO.Result = false;
                _validationResultDTO.Message = "Error!";
                _validationResultDTO.Description = string.Format("There was an error trying to save the record. ");
            }
            return _validationResultDTO;
        }
        public static ValidationResultDTO UpdateStudent(StudentDTO StudentDTO)
        {
            var _validationResultDTO = new ValidationResultDTO
            {
                Description = "The record has been updated successfully."
            };
            try
            {
                using (var _unit = XPO_Helper.GetNewUnitOfWork())
                {
                    var _studentXPO = StudentMap.DTOtoXPO(StudentDTO, _unit);
                    _unit.Save(_studentXPO);
                    _unit.CommitChanges();
                }
            }
            catch (Exception ex)
            {
                
                _validationResultDTO.Result = false;
                _validationResultDTO.Message = "Error!";
                _validationResultDTO.Description = string.Format("There was an error trying to save the record.");
            }
            return _validationResultDTO;
        }
        public static ValidationResultDTO DeleteStudent(StudentDTO StudentDTO)
        {
            var _validationResultDTO = new ValidationResultDTO
            {
                Description = "The record has been deleted successfully."
            };
            try
            {
                using (var _unit = XPO_Helper.GetNewUnitOfWork())
                {
                    var _studentXPO = StudentMap.DTOtoXPO(StudentDTO, _unit);
                    _unit.Delete(_studentXPO);
                    _unit.CommitChanges();
                    _unit.PurgeDeletedObjects();
                }
            }
            catch (Exception ex)
            {
                
                _validationResultDTO.Result = false;
                _validationResultDTO.Message = "Error!";
                _validationResultDTO.Description = string.Format("There was an error trying to save the record.");
            }
            return _validationResultDTO;
        }
    }
}
