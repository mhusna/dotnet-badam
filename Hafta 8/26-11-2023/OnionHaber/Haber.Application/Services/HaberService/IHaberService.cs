using Haber.Application.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.Application.Services.HaberService
{
    public interface IHaberService
    {
        Task HaberEkleAsync(HaberEkleDTO haberEkleDTO);
        IEnumerable<Haber.Domain.Entities.Haber> HaberListele();
    }
}
