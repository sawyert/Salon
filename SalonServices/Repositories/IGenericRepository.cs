using SalonServices.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalonServices.Repositories
{
    public interface IGenericRepository<T> where T : AbstractEntity
    {
        Task<T> Add(T pEntity);
        Task Update(T pEntity);
        Task<T> GetById(int id);
    }
}
