﻿using SalonServices.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalonServices.Repositories
{
    public interface IPhotoOrganisationRepository : IGenericRepository<PhotoOrganisationEntity>
    {
        Task<List<PhotoOrganisationEntity>> GetAllWithAwards();

        Task<List<PhotoOrganisationEntity>> GetAllBasic();
    }
}
