using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.BLL.Common;
using RepositoryPattern.BLL.Features.Student;

namespace RepositoryPattern.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        //Metodo Post para crear
        //Recibe un Student DTO en el cuerpo de la peticion
        [HttpPost]
        public ValidationResultDTO CreateStudent(StudentDTO StudentDTO)
        {            
            var _validationResultDTO = Student_Service.CreateStudent_Global(StudentDTO);
            return _validationResultDTO;
        }
        //Metodo Put para actualizar
        //Recibe un Student DTO en el cuerpo de la peticion
        [HttpPut]
        public ValidationResultDTO UpdateStudent(StudentDTO StudentDTO)
        {
            var _validationResultDTO = Student_Service.UpdateStudent_Global(StudentDTO);
            return _validationResultDTO;
        }
        //Metodo Delete para eliminar
        //Recibe un Student DTO en el cuerpo de la peticion
        [HttpDelete]
        public ValidationResultDTO DeleteStudent(StudentDTO StudentDTO)
        {
            var _validationResultDTO = Student_Service.DeleteStudent_Global(StudentDTO);
            return _validationResultDTO;
        }

        //Metodo Get para consultar
        //puede recibir un Student DTO en la url de la peticion
        [HttpGet]
        public List<StudentDTO> CreateStudent_Global([FromQuery] StudentDTO StudentDTO)
        {
            var _StudentsList = Student_Service.GetStudentList_Global(StudentDTO);
            return _StudentsList;
        }
    }
}
