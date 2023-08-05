using System;
using System.Collections.Generic;

namespace RepositoryPattern.BLL.Features.Student
{
    public class StudentDTO
    {
        #region Base Properties
        public int? ID { get; set; }
        public string? Name { get; set; }
        public int Grade { get; set; }
        public bool? Pass { get; set; }
        public int AddedByID { get; set; }
        public int LastUpdateByID { get; set; }
        
        #endregion

        #region Extended Properties
            
        
        #endregion
        #region Constructor
        public StudentDTO()
        {
                
        }
        #endregion
    }
}
