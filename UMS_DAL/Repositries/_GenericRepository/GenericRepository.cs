﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_DAL.Models;

namespace UMS_DAL.Repositries._GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T:class
    {
        public readonly DbSet<T> _dbSet;
        public readonly UmsContext _umsContext;
        public GenericRepository(UmsContext umsContext)
        {
            _umsContext = umsContext;
            _dbSet= _umsContext.Set<T>();
        }

        #region Get
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public T GetByID(int id)
        {
            return _dbSet.Find(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }



        #endregion

        #region ADD 
        public T Add(T entity)
        {
            try
            {
                var result = _dbSet.Add(entity); // add method have changed the reference of  the T 
                _umsContext.SaveChanges();
                return result.Entity;
                //return T
            }
            catch (Exception ex) //middlewear
            {
                throw new Exception();
            }
        }
        #endregion

        #region Update
        public T Update(T entity)
        {
            try
            {
                _dbSet.Update(entity);
                _umsContext.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
        #endregion

        #region Delete
        public bool Delete(T entity)
        {
            try
            {
                if (entity != null)
                {
                    _dbSet.Remove(entity);
                    _umsContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }

            catch (Exception ex)
            {
                throw new Exception();
            }

        }

        public bool Delete(int id)
        {
            try
            {
                var entity = GetByID(id);
                return Delete(entity);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }


        #endregion
    }
}

