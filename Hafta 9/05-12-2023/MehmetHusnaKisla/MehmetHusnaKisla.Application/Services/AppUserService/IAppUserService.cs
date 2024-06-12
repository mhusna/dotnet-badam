using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Application.Services.AppUserService
{
    public interface IAppUserService
    {
        int GetUserId(ClaimsPrincipal claims);
    }
}
