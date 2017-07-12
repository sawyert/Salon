using SalonServices.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalonServices
{
    public interface IAwardService
    {
        Task<PersonAwardTableDto> GetAwardLevelsForPerson(int pPersonId);
    }
}
