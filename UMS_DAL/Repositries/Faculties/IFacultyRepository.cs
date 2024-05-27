﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_DAL.Models;
using UMS_DAL.Repositries._GenericRepository;

namespace UMS_DAL.Repositries.Faculties
{
    public interface IFacultyRepository:IGenericRepository<Faculty>
    {
        Faculty GetFacultyByName(string name);
    }
}
