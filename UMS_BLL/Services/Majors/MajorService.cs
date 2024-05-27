using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO.Faculties;
using UMS_BLL.DTO.Majors;
using UMS_BLL.Services.Faculties;
using UMS_BLL.Services.GenericServices;
using UMS_BLL.Wrapping;
using UMS_DAL.Models;
using UMS_DAL.Repositries.Faculties;
using UMS_DAL.Repositries.Majors;

namespace UMS_BLL.Services.Majors
{
    using Entity = Major;
    using Dto = MajorDTO;
    public class MajorService : GenericService<Entity, Dto>, IMajorService
    {
        private readonly IMajorRepository _majorRepository;
        private readonly IMapper _mapper;
        public MajorService(IMajorRepository majorRepository, IMapper mapper) : base(majorRepository, mapper)
        {
            _majorRepository = majorRepository;
            _mapper = mapper;
        }

        public APIResponse<IEnumerable<Dto>> GetMajorsByFacultyId(int facultyId)
        {
            var response = new APIResponse<IEnumerable<Dto>>();
            var result = _majorRepository.GetMajorsByFacultyId(facultyId);
            response.Data= _mapper.Map<IEnumerable<Dto>>(result);
            return response;
        }
    }
}
