using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.BLL.Common
{
    public class Validation_ResultDTO
    {
        #region Base Properties
        public int ID { get; set; }
        public bool Result { get; set; }
        public string Description { get; set; }
        public string Message { get; set; }
        #endregion

        #region Extended Properties
        public List<Validation_ResultDTO> Validation_ResultList { get; set; }
        public dynamic Value { get; set; }

        #endregion

        #region Constructor
        public Validation_ResultDTO()
        {
            Result = true;
            Message = "Success";
            Validation_ResultList = new List<Validation_ResultDTO>();
        }
        #endregion


    }
}
