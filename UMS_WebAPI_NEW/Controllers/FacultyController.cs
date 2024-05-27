using Microsoft.AspNetCore.Mvc;
using UMS_BLL.DTO.Faculties;
using UMS_BLL.Services.Faculties;
using UMS_BLL.Services.GenericServices;
using UMS_BLL.Wrapping;
using UMS_DAL.Models;
using UMS_DAL.Repositries.Faculties;

namespace UMS_WebAPI_NEW.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class FacultyController : GenericController<FacultyDTO>
    {
        private readonly IFacultyService _facultyService;
        public FacultyController(IFacultyService genericService) : base(genericService)
        {
            _facultyService = genericService;
        }

        [HttpGet("GetFacultyByName")]
        public APIResponse<FacultyDTO> GetFacultyByName(string name)
        {
            return _facultyService.GetFacultyByName(name);
        }
    }
}
