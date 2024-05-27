using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO;
using UMS_BLL.DTO.Faculties;
using UMS_BLL.Services.GenericServices;
using UMS_BLL.Wrapping;
using UMS_DAL.Models;
using UMS_DAL.Repositries._GenericRepository;
using UMS_DAL.Repositries.Faculties;

namespace UMS_BLL.Services.Faculties
{
    public class FacultyService:GenericService<Faculty,FacultyDTO> ,IFacultyService
    {
        private readonly IFacultyRepository _facultyRepository;
        private readonly IMapper _mapper;
        public FacultyService(IFacultyRepository facultyRepository, IMapper mapper):base(facultyRepository,mapper)
        {
            _facultyRepository = facultyRepository;
            _mapper=mapper;
        }
        
        public APIResponse<FacultyDTO> GetFacultyByName(string name)
        {
            var response = new APIResponse<FacultyDTO>();
            var result = _facultyRepository.GetFacultyByName(name);
            response.Data= _mapper.Map<FacultyDTO>(result);
            return response;
        }
    }
}
