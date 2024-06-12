using AutoMapper;
using MehmetHusnaKisla.Application.Models.DTOs;
using MehmetHusnaKisla.Application.Models.VMs;
using MehmetHusnaKisla.Domain.Entities;
using MehmetHusnaKisla.Domain.Enums;
using MehmetHusnaKisla.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Application.Services.EssayService
{
    public class EssayService : IEssayService
    {
        private readonly IEssayRepository _repository;
        private readonly IMapper _mapper;

        public EssayService(IEssayRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task DeleteEssay(int id)
        {
            await _repository.DeleteEntity(id);
        }

        public async Task InsertEssay(EssayInsertDTO essayInsertDTO)
        {
            Essay essay = new Essay();
            _mapper.Map(essayInsertDTO, essay);

            await _repository.InsertEntity(essay);
        }

        public async Task UpdateEssay(EssayUpdateDTO essayUpdateDTO)
        {
            Essay essay = new Essay();
            _mapper.Map(essayUpdateDTO, essay);

            await _repository.UpdateEntity(essay);
        }

        public async Task<IEnumerable<EssayListVM>> ListActiveEssays()
        {
            var listOfEssays = await _repository.GetAllEntitiesForBeAbleToIncludeEntities()
                                                .Where(x => x.RecordStatus == RecordStatus.Active)
                                                .Include(x => x.Topic)
                                                .Include(x => x.Publisher)
                                                .ToListAsync();

            List<EssayListVM> essayListVM = new List<EssayListVM>();
            _mapper.Map(listOfEssays, essayListVM);

            return essayListVM;
        }

        public async Task<IEnumerable<EssayListVM>> ListAllEssays()
        {
            var listOfEssays = await _repository.GetAllEntitiesForBeAbleToIncludeEntities()
                                                .Include(x => x.Topic)
                                                .ToListAsync();

            List<EssayListVM> essayListVM = new List<EssayListVM>();
            _mapper.Map(listOfEssays, essayListVM);

            return essayListVM;
        }

        public async Task<int> EssayCount()
        {
            var listOfEssays = await _repository.GetAllEntitiesForBeAbleToIncludeEntities()
                                                .Where(x => x.RecordStatus == RecordStatus.Active)
                                                .Include(x => x.Topic)
                                                .ToListAsync();

            return listOfEssays.Count();
        }

        public async Task<EssayDetailVM> GetEssay(int id)
        {
            var essay = await _repository.GetAllEntitiesForBeAbleToIncludeEntities()
                                                           .Where(x => x.EssayID == id)
                                                           .Include(x => x.Topic)
                                                           .Include(x => x.Publisher)
                                                           .FirstOrDefaultAsync();

            EssayDetailVM essayDetailVM = new EssayDetailVM();
            _mapper.Map(essay, essayDetailVM);

            return essayDetailVM;
        }
    }
}
