using Haber.Application.Models.DTOs;
using Haber.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.Application.Services.AppUserService
{
    public class AppUserService : IAppUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AppUserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<bool> LoginAsync(LoginDTO login)
        {
            var user = await _userManager.FindByNameAsync(login.UserName);
            if (user == null)
                return false;

            var passwordIsCorrect = await _userManager.CheckPasswordAsync(user, login.Password);
            if(!passwordIsCorrect)
                return false;

            await _signInManager.SignInAsync(user, false);
            return true;
        }

        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<bool> RegisterAsync(UyeKayitDTO uye)
        {
            AppUser user = new AppUser()
            {
                Ad = uye.Ad,
                Soyad = uye.Soyad,
                UserName = uye.UserName,
                Email = uye.Email
            };

            PasswordHasher<AppUser> hasher = new PasswordHasher<AppUser>();
            user.PasswordHash = hasher.HashPassword(user, uye.Password);

            var result = await _userManager.CreateAsync(user);
            await _userManager.IsInRoleAsync(user, "Uye");

            return result.Succeeded;
        }

        public Task UpdateAsync(UyeGuncelleDTO uye)
        {
            throw new NotImplementedException();
        }
    }
}
