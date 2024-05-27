using Microsoft.AspNetCore.Mvc;
using UMS_BLL.DTO.Faculties;
using UMS_BLL.DTO.Majors;
using UMS_BLL.Services.GenericServices;
using UMS_BLL.Services.Majors;
using UMS_BLL.Wrapping;

namespace UMS_WebAPI_NEW.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class MajorController : GenericController<MajorDTO>
    {
        private readonly IMajorService _majorService;

        public MajorController(IMajorService genericService) : base(genericService)
        {
            _majorService = genericService;
        }

        [HttpGet("GetMajorByFacultyId")]
        public APIResponse<IEnumerable<MajorDTO>> GetMajorByFacultyId(int id)
        {
            return _majorService.GetMajorsByFacultyId(id);
        }
    }
}
