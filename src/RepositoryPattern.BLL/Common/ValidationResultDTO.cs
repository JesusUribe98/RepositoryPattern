using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.BLL.Common
{
    public class ValidationResultDTO
    {
        #region Base Properties
        public int ID { get; set; }
        public bool Result { get; set; }
        public string Description { get; set; }
        public string Message { get; set; }
        #endregion

        #region Extended Properties
        public List<ValidationResultDTO> Validation_ResultList { get; set; }
        public dynamic Value { get; set; }

        #endregion

        #region Constructor
        public ValidationResultDTO()
        {
            Result = true;
            Message = "Success";
            Validation_ResultList = new List<ValidationResultDTO>();
        }
        #endregion


    }
}
