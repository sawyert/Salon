using System;
using SalonServices.Entities;
using SalonServices.Repositories.Interfaces;

namespace SalonServices.Repositories
{
    public class ImageRepository : IImageRepository
    {
        private readonly ISalonDbContext dbContext;

        public ImageRepository(ISalonDbContext pDbContext)
        {
            this.dbContext = pDbContext;
        }

        public ImageEntity GetById(int pImageId)
        {
            var lReturn = this.dbContext.Images.Find(pImageId);
            return lReturn;
        }
    }
}
