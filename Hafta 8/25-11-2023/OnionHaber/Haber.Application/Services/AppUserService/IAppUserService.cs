using Haber.Application.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.Application.Services.AppUserService
{
    public interface IAppUserService
    {
        Task<bool> LoginAsync(LoginDTO login);
        Task LogoutAsync();
        Task<bool> RegisterAsync(UyeKayitDTO uye);
        Task UpdateAsync(UyeGuncelleDTO uye);
    }
}
