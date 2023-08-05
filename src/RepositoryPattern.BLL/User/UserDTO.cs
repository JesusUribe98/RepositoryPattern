using System;
using System.Collections.Generic;

namespace RepositoryPattern.BLL.Features.User
{
    public class UserDTO
    {
        #region Base Properties
        public int? ID { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        
        #endregion

        #region Extended Properties
            
        
        #endregion
        #region Constructor
        public UserDTO()
        {
                
        }
        #endregion
    }
}
