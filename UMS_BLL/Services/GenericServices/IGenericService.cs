using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO.Faculties;
using UMS_BLL.Wrapping;

namespace UMS_BLL.Services.GenericServices
{
    public interface IGenericService<Dto> where Dto : class
    {
        APIResponse<IEnumerable<Dto>> GetAll();
        APIResponse<Dto> GetByID(int id);
        APIResponse<Dto> Add(Dto dto);
        APIResponse<Dto> Update(Dto dto);
        APIResponse<bool> Delete(int id);
        APIResponse<bool> Delete(Dto dto);
    }
}
