using SalonServices.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalonServices
{
    public interface IPersonAwardService
    {
        Task<PersonAwardTableDto> GetAwardLevelsForPerson(int pPersonId);

        Task<List<BasicPersonDto>> GetAllPersons();
    }
}
