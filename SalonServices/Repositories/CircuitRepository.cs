using Microsoft.EntityFrameworkCore;
using SalonServices.Entities;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace SalonServices.Repositories
{
    public class CircuitRepository : ICircuitRepository
    {
        private readonly ISalonDbContext dbContext;

        public CircuitRepository(ISalonDbContext pDbContext)
        {
            this.dbContext = pDbContext;
        }

        public async Task<CircuitEntity> Add(CircuitEntity pEntity)
        {
            await this.dbContext.Circuits.AddAsync(pEntity);
            await this.dbContext.SaveChangesAsync();
            return pEntity;
        }

        public async Task<CircuitEntity> GetById(int id)
        {
            return await this.dbContext.Circuits.FirstOrDefaultAsync(cir => cir.Id == id);
        }

        public async Task Update(CircuitEntity pEntity)
        {
            this.dbContext.Circuits.Update(pEntity);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task Delete(CircuitEntity pEntity)
        {
            this.dbContext.Circuits.Remove(pEntity);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<List<CircuitEntity>> GetAll()
        {
            return await this.dbContext.Circuits.ToListAsync();
        }
    }
}
