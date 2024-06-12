using AutoMapper;
using Haber.Application.Models.DTOs;
using Haber.Domain.Repositories.Abstract;
using Haber.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.Application.Services.HaberService
{
    public class HaberService : IHaberService
    {
        private readonly IHaberRepository _haberRepository;
        private readonly IMapper _mapper;

        public HaberService(IHaberRepository haberRepository, IMapper mapper)
        {
            _haberRepository = haberRepository;
            _mapper = mapper;
        }

        public async Task HaberEkleAsync(HaberEkleDTO haberEkleDTO)
        {
            Haber.Domain.Entities.Haber haber = new Haber.Domain.Entities.Haber();

            // Doludan boşa..
            _mapper.Map(haberEkleDTO, haber);
            await _haberRepository.EkleAsync(haber);
        }

        public IEnumerable<Domain.Entities.Haber> HaberListele()
        {
            return _haberRepository.TumunuGetir().Include(x => x.Kategori).ToList();
        }
    }
}
