using EasyCup.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCup.Service.Services.Interfaces
{
    public interface IFootballSchoolService
    {
        Task<FootballSchool> Add(FootballSchool footballSchool);

        Task Update(FootballSchool footballSchool);

        Task<FootballSchool> GetByID(int id);

        Task<List<FootballSchool>> GetAll();

        Task Delete(int id);
    }
}
