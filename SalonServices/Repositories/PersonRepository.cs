using Microsoft.EntityFrameworkCore;
using SalonServices.Entities;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalonServices.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ISalonDbContext dbContext;

        public PersonRepository(ISalonDbContext pDbContext)
        {
            this.dbContext = pDbContext;
        }

        public async Task<PersonEntity> Add(PersonEntity pEntity)
        {
            await this.dbContext.People.AddAsync(pEntity);
            await this.dbContext.SaveChangesAsync();
            return pEntity;
        }

        public async Task<PersonEntity> GetById(int id)
        {
            return await this.dbContext.People.FirstOrDefaultAsync(peo => peo.Id == id);
        }

        public async Task Update(PersonEntity pEntity)
        {
            this.dbContext.People.Update(pEntity);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task Delete(PersonEntity pEntity)
        { 
            this.dbContext.People.Remove(pEntity);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<PersonEntity> GetWithSubmissionsSalonsAccreditationSections(int pPersonId)
        {
            return await this.dbContext.People
                .Include(per => per.Submissions)
                    .ThenInclude(sub => sub.SalonYear)
                    .ThenInclude(saly => saly.Accreditations)
                .Include(per => per.Submissions)
                    .ThenInclude(sub => sub.Entries)
                    .ThenInclude(ent => ent.Section)
                    .ThenInclude(sub => sub.SalonYear)
                    .ThenInclude(saly => saly.Salon)
                .Include(per => per.Submissions)
                    .ThenInclude(sub => sub.Entries)
                    .ThenInclude(ent => ent.Section)
                    .ThenInclude(ent => ent.SectionType)
                .FirstOrDefaultAsync(per => per.Id == pPersonId);
        }
        
        public async Task<List<PersonEntity>> GetAll()
        {
            return await this.dbContext.People.ToListAsync();
        }

        public async Task<decimal> GetCostPerAcceptance(int id)
        {
            PersonEntity lPerson = await this.GetById(id);
            decimal lTotalCost = await this.GetTotalCost(id);
            int lAcceptanceCount = await this.dbContext.CompetitionEntries.Where(itm => itm.IsAccepted.HasValue && itm.IsAccepted == true && itm.Image.Person == lPerson).CountAsync();
            return lTotalCost / lAcceptanceCount;
        }

        public async Task<decimal> GetTotalCost(int id)
        {
            PersonEntity lPerson = await this.GetById(id);
            return this.dbContext.Submissions.Where(sub => sub.Person == lPerson).Sum(itm => itm.EntryCost);
        }

        public async Task<int> UnjudgedImageCount(int id)
        {
            return await this.dbContext.Submissions.Where(sub => sub.IsJudged == false).SelectMany(sub => sub.Entries).CountAsync();
        }

        public async Task<int> UnjudgedSalonCount(int id)
        {
            return await this.dbContext.Submissions.Where(sub => sub.IsJudged == false).CountAsync();
        }
    }
}
