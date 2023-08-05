using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.BLL.Common;
using RepositoryPattern.BLL.Features.Student;
using RepositoryPattern.BLL.Features.Student;

namespace RepositoryPattern.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpPost]
        public ValidationResultDTO CreateStudent(StudentDTO StudentDTO)
        {
            var _validationResultDTO = Student_Helper.CreateStudent_Global(StudentDTO);
            return _validationResultDTO;
        }
        [HttpPut]
        public ValidationResultDTO UpdateStudent(StudentDTO StudentDTO)
        {
            var _validationResultDTO = Student_Helper.UpdateStudent_Global(StudentDTO);
            return _validationResultDTO;
        }
        [HttpDelete]
        public ValidationResultDTO DeleteStudent(StudentDTO StudentDTO)
        {
            var _validationResultDTO = Student_Helper.DeleteStudent_Global(StudentDTO);
            return _validationResultDTO;
        }
        [HttpGet]
        public List<StudentDTO> CreateStudent_Global([FromQuery] StudentDTO StudentDTO)
        {
            var _StudentsList = Student_Helper.GetStudentList_Global(StudentDTO);
            return _StudentsList;
        }
    }
}
