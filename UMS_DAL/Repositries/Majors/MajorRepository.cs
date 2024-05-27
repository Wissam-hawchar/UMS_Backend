using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_DAL.Models;
using UMS_DAL.Repositries._GenericRepository;

namespace UMS_DAL.Repositries.Majors
{
    public class MajorRepository : GenericRepository<Major>, IMajorRepository
    {
        public MajorRepository(UmsContext umsContext) : base(umsContext)
        {
        }

        public IEnumerable<Major> GetMajorsByFacultyId(int facultyId)
        {
            return _dbSet.Where(x=>x.FacultyId == facultyId).ToList();
        }
    }
}
