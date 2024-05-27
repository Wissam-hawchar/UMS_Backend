using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO.Faculties;
using UMS_BLL.Services.GenericServices;
using UMS_BLL.Wrapping;

namespace UMS_BLL.Services.Faculties
{
    public interface IFacultyService:IGenericService<FacultyDTO>
    {
        APIResponse<FacultyDTO> GetFacultyByName(string name);
    }
}
