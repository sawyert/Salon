using Microsoft.EntityFrameworkCore;
using SalonServices.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalonServices
{
    public interface ISalonDbContext
    {
        DbSet<CountryEntity> Countries { get; set; }
    }
}
