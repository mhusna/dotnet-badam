using AutoMapper;
using Haber.Application.Models.DTOs;
using Haber.Application.Models.VMs;
using Haber.Domain.Enums;
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

        public async Task<HaberDetayVM> HaberDetayAsync(int id)
        {
            var haber = await _haberRepository.TumunuFiltreleAsync(x => x,
                                                             x => x.HaberID == id,
                                                             null,
                                                             x => x.Include(x => x.Kategori).Include(x => x.Yorumlar).ThenInclude(x => x.User));

            HaberDetayVM haberDetay = new HaberDetayVM();
            _mapper.Map(haber.SingleOrDefault(), haberDetay);
            return haberDetay;
        }

        public async Task HaberEkleAsync(HaberEkleDTO haberEkleDTO)
        {
            Haber.Domain.Entities.Haber haber = new Haber.Domain.Entities.Haber();

            // Doludan boşa..
            _mapper.Map(haberEkleDTO, haber);
            await _haberRepository.EkleAsync(haber);
        }

        public async Task HaberiPasifHaleGetir(int id)
        {
            await _haberRepository.SilAsync(id);
        }

        public IEnumerable<Domain.Entities.Haber> HaberListele()
        {
            return _haberRepository.TumunuGetir().Include(x => x.Kategori).ToList();
        }

        public async Task<IEnumerable<HaberVM>> TumAktifHaberlerAsync()
        {
            //var haberler = _haberRepository.BulAsync(x => x.KayitDurumu == KayitDurumu.Aktif);
            var haberler = await _haberRepository.TumunuFiltreleAsync(x => x,
                                                                x => x.KayitDurumu == KayitDurumu.Aktif,
                                                                x => x.OrderByDescending(x => x.EklemeTarihi),
                                                                x => x.Include(x => x.Kategori));

            List<HaberVM> haberlerVM = new List<HaberVM>();
            _mapper.Map(haberler, haberlerVM);

            return haberlerVM;
        }

        public async Task<IEnumerable<AdminHaberVM>> TumHaberlerAsync()
        {
            var haberler = await _haberRepository.TumunuGetir().OrderByDescending(x => x.EklemeTarihi)
                                                               .Include(x => x.Kategori)
                                                               .ToListAsync();

            List<AdminHaberVM> haberlerVM = new List<AdminHaberVM>();
            _mapper.Map(haberler, haberlerVM);

            return haberlerVM;
        }
    }
}
