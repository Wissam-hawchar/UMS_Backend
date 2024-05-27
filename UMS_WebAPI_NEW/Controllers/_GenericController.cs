using Microsoft.AspNetCore.Mvc;
using UMS_BLL.DTO.Faculties;
using UMS_BLL.Services.GenericServices;
using UMS_BLL.Wrapping;

namespace UMS_WebAPI_NEW.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class GenericController<Dto> : Controller where Dto : class
    {
        private readonly IGenericService<Dto> _genericService;

        public GenericController(IGenericService<Dto> genericService)
        {
            _genericService = genericService;
        }

        [HttpGet("GetAll")]
        public APIResponse<IEnumerable<Dto>> GetAll()
        {
            return _genericService.GetAll();
        }
        [HttpGet("GetById")]
        public APIResponse<Dto> GetById(int id)
        {
            return _genericService.GetByID(id);
        }

        [HttpPost("Add")]
        public APIResponse<Dto> Add(Dto dto)
        {
            return _genericService.Add(dto);
        }

        [HttpPut("Update")]
        public APIResponse<Dto> Update(Dto dto)
        {
            return _genericService.Update(dto);
        }

        [HttpDelete("DeleteById")]
        public APIResponse<bool> DeleteById(int id)
        {
            return _genericService.Delete(id);
        }

        [HttpDelete("Delete")]
        public APIResponse<bool> Delete(Dto dto)
        {
            return _genericService.Delete(dto);
        }
    }
}
