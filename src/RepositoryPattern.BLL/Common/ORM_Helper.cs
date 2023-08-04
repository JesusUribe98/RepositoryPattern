using RepositoryPattern.DAL.XPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.BLL.Common
{
    public class ORM_Helper
    {
        public static Validation_ResultDTO UpdateSchema()
        {
            var _validation_resultDTO = new Validation_ResultDTO { Description = "The DB has been updated successfully" };
            try
            {
                using (var _unit = XPO_Helper.GetNewSession())
                {
                    _unit.UpdateSchema();
                    _unit.CreateObjectTypeRecords();
                }
            }
            catch (Exception ex)
            {
                _validation_resultDTO.Result = false;
                _validation_resultDTO.Message = "Error";
                _validation_resultDTO.Description = string.Format("There was an error trying to update the DB. ");
                throw ex;
            }
            return _validation_resultDTO;
        }
    }
}
