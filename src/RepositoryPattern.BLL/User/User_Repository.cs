using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using RepositoryPattern.BLL.Common;
using RepositoryPattern.DAL.XPO;
using RepositoryPattern.DAL.XPO.RepositoryPattern;

namespace RepositoryPattern.BLL.Features.User
{
    public class User_Repository
    {
        public static List<UserDTO> GetUserList(UserDTO UserDTO)
        {
            var _userList = new List<UserDTO>();
            try
            {
                // User Filters
                var _groupOperator = User_Filter.GetUserFilters(UserDTO);
                

                using (var _session = XPO_Helper.GetNewSession())
                {
                    var _userCollection = new XPCollection<UserXPO>(_session, _groupOperator)
                    {
                        Sorting = new SortingCollection(new SortProperty(nameof(UserXPO.Oid), SortingDirection.Ascending))
                    };

                    if (_userCollection.AsQueryable().Count() > 0)
                    {
                        _userList = _userCollection.Select(UserXPO => UserMap.XPOToDTO(UserXPO)).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _userList;
        }
        
        public static ValidationResultDTO CreateUser(UserDTO UserDTO)
        {
            var _validationResultDTO = new ValidationResultDTO
            {
                Description = "The record has been saved successfully."
            };
            try
            {
                using (var _unit = XPO_Helper.GetNewUnitOfWork())
                {
                    var _userXPO = UserMap.DTOtoXPO(UserDTO, _unit);
                    _unit.Save(_userXPO);
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
        public static ValidationResultDTO UpdateUser(UserDTO UserDTO)
        {
            var _validationResultDTO = new ValidationResultDTO
            {
                Description = "The record has been updated successfully."
            };
            try
            {
                using (var _unit = XPO_Helper.GetNewUnitOfWork())
                {
                    var _userXPO = UserMap.DTOtoXPO(UserDTO, _unit);
                    _unit.Save(_userXPO);
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
        public static ValidationResultDTO DeleteUser(UserDTO UserDTO)
        {
            var _validationResultDTO = new ValidationResultDTO
            {
                Description = "The record has been deleted successfully."
            };
            try
            {
                using (var _unit = XPO_Helper.GetNewUnitOfWork())
                {
                    var _userXPO = UserMap.DTOtoXPO(UserDTO, _unit);
                    _unit.Delete(_userXPO);
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
