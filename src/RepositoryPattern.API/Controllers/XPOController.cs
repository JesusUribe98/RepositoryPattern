using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.BLL.Common;

namespace RepositoryPattern.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class XPOController : ControllerBase
    {
        public XPOController() { }

        [HttpGet]
        public Validation_ResultDTO UpdateSchema()
        {
            var _validation_ResultDTO = ORM_Helper.UpdateSchema();
            return _validation_ResultDTO;
        }
    }
}
