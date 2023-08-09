using DevExpress.Xpo;
using RepositoryPattern.DAL.XPO.RepositoryPattern;
using System;

namespace RepositoryPattern.BLL.Features.Student
{
    public class StudentMap
    {
        //Funcion para mapear objetos de tipo XPO a DTO
        public static StudentDTO XPOToDTO(StudentXPO StudentXPO)
        {
            var _studentDTO = new StudentDTO();
            try
            {
                _studentDTO.ID = StudentXPO.Oid;
                _studentDTO.Name = StudentXPO.Name;
                _studentDTO.Grade = StudentXPO.Grade;
                _studentDTO.Pass = StudentXPO.Pass;
                _studentDTO.AddedByID = StudentXPO.AddedBy != null ? StudentXPO.AddedBy.Oid : 0;
                _studentDTO.LastUpdateByID = StudentXPO.LastUpdateBy != null ? StudentXPO.LastUpdateBy.Oid : 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _studentDTO;
        }
        //Funcion para mapear objetos de tipo DTO a XPO
        public static StudentXPO DTOtoXPO(StudentDTO StudentDTO, UnitOfWork UnitOfWork)
        {
            StudentXPO _studentXPO;
            try
            {
                _studentXPO = StudentDTO.ID == null ? new StudentXPO(UnitOfWork) : UnitOfWork.GetObjectByKey<StudentXPO>(StudentDTO.ID);
                _studentXPO.Name = _studentXPO.Name == StudentDTO.Name ? _studentXPO.Name : StudentDTO.Name;
                _studentXPO.Grade = _studentXPO.Grade == StudentDTO.Grade ? _studentXPO.Grade : StudentDTO.Grade;
                _studentXPO.Pass = _studentXPO.Pass == StudentDTO.Pass.GetValueOrDefault() ? _studentXPO.Pass : StudentDTO.Pass.GetValueOrDefault();
                _studentXPO.AddedBy = _studentXPO.AddedBy != null ? _studentXPO.AddedBy : UnitOfWork.GetObjectByKey<UserXPO>(StudentDTO.AddedByID);
                _studentXPO.LastUpdateBy = _studentXPO.LastUpdateBy != null ? _studentXPO.LastUpdateBy : UnitOfWork.GetObjectByKey<UserXPO>(StudentDTO.LastUpdateByID);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _studentXPO;
        }

    }
}
