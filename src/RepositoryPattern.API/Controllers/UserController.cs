﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.BLL.Common;
using RepositoryPattern.BLL.Features.User;

namespace RepositoryPattern.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public  ValidationResultDTO CreateUser(UserDTO UserDTO)
        {
            var _validationResultDTO = User_Helper.CreateUser_Global(UserDTO);
            return _validationResultDTO;
        }
        [HttpPut]
        public ValidationResultDTO UpdateUser(UserDTO UserDTO)
        {
            var _validationResultDTO = User_Helper.UpdateUser_Global(UserDTO);
            return _validationResultDTO;
        }
        [HttpDelete]
        public ValidationResultDTO DeleteUser(UserDTO UserDTO)
        {
            var _validationResultDTO = User_Helper.DeleteUser_Global(UserDTO);
            return _validationResultDTO;
        }
        [HttpGet]
        public List<UserDTO> CreateUser_Global([FromQuery] UserDTO UserDTO)
        {
            var _usersList = User_Helper.GetUserList_Global(UserDTO);
            return _usersList;
        }
    }
}
