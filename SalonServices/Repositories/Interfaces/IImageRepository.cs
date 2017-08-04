using System;
using SalonServices.Entities;

namespace SalonServices.Repositories.Interfaces
{
    public interface IImageRepository
    {
        ImageEntity GetById(int pImageId);
    }
}
