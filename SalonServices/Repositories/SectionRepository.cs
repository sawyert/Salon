﻿using Microsoft.EntityFrameworkCore;
using SalonServices.Entities;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalonServices.Repositories
{
    public class SectionRepository : ISectionRepository
    {
        private readonly ISalonDbContext dbContext;

        public SectionRepository(ISalonDbContext pDbContext)
        {
            this.dbContext = pDbContext;
        }

        public async Task<SectionEntity> Add(SectionEntity pEntity)
        {
            await this.dbContext.SalonSections.AddAsync(pEntity);
            await this.dbContext.SaveChangesAsync();
            return pEntity;
        }

        public async Task<SectionEntity> GetById(int id)
        {
            return await this.dbContext.SalonSections.Include(sec => sec.SalonYear).FirstOrDefaultAsync(coun => coun.Id == id);
        }

        public async Task Update(SectionEntity pEntity)
        {
            this.dbContext.SalonSections.Update(pEntity);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task Delete(SectionEntity pEntity)
        {
            this.dbContext.SalonSections.Remove(pEntity);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<List<SectionEntity>> GetSectionsBySalonYearSectionTypeIds(int salonYearId, List<int> sectionTypeIds)
        {
            return await this.dbContext.SalonSections.Where(ss => ss.SalonYearId == salonYearId && sectionTypeIds.Contains(ss.SectionTypeId)).ToListAsync();
        }
    }
}
