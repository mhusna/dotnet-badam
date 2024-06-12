using MehmetHusnaKisla.Application.Models.DTOs;
using MehmetHusnaKisla.Application.Models.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Application.Services.EssayService
{
    public interface IEssayService
    {
        Task InsertEssay(EssayInsertDTO essayInsertDTO);
        Task DeleteEssay(int id);
        Task UpdateEssay(EssayUpdateDTO essayUpdateDTO);

        Task<EssayDetailVM> GetEssay(int id);

        Task<IEnumerable<EssayListVM>> ListActiveEssays();
        Task<IEnumerable<EssayListVM>> ListAllEssays();

        Task<int> EssayCount();

    }
}
