using AutoMapper;
using Haber.Application.Models.DTOs;
using Haber.Domain.Entities;
using Haber.Domain.Enums;
using Haber.Domain.Repositories.Abstract;
using Haber.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.Application.Services.KategoriService
{
    public class KategoriService : IKategoriService
    {
        private readonly IKategoriRepository _kategoriRepository;
        private readonly IMapper _mapper;

        public KategoriService(IKategoriRepository kategoriRepository, IMapper mapper)
        {
            _kategoriRepository = kategoriRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<KategoriDTO>> TumAktifKategorilerAsync()
        {
            var kategoriler = await _kategoriRepository.BulAsync(x => x.KayitDurumu == KayitDurumu.Aktif);

            IEnumerable<KategoriDTO> liste = new List<KategoriDTO>();
            return _mapper.Map(kategoriler, liste);
        }
    }
}
