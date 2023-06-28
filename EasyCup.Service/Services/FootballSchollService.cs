using EasyCup.Domain;
using EasyCup.Domain.Interface;
using EasyCup.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCup.Service.Services
{
    public class FootballSchollService : IFootballSchoolService
    {
        #region Fields

        private readonly IRepository<FootballSchool> _footballSchoolRepository;

        #endregion

        #region Construtor

        public FootballSchollService(IRepository<FootballSchool> footballSchoolRepository)
        {
            _footballSchoolRepository = footballSchoolRepository;
        }

        #endregion

        public async Task<FootballSchool> Add(FootballSchool footballSchool)
        {
            //var hasName = await _footballSchoolRepository.SelectFirstBy(x => x.Name == footballSchool.Name);
            //if (hasName != null)
            //    throw new Exception("Nome já existe");

            footballSchool = await _footballSchoolRepository.Insert(footballSchool);

            return footballSchool;
        }

        public async Task Delete(int id)
        {
            await _footballSchoolRepository.DeleteFirstBy(x => x.ID == id);
        }

        public async Task<FootballSchool> GetByID(int id)
        {
            return await _footballSchoolRepository.SelectFirstBy(x => x.ID == id);
        }

        public async Task<List<FootballSchool>> GetAll()
        {
            var result = await _footballSchoolRepository.Select();

            return result.ToList();
        }

        public async Task Update(FootballSchool footballSchool)
        {
            await _footballSchoolRepository.Update(footballSchool);
        }
    }
}
