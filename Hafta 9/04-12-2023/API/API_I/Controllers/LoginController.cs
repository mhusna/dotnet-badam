using API_I.Models;
using API_I.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace API_I.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly UserManager<AspNetUser> _userManager;
        private readonly SignInManager<AspNetUser> _signInManager;
        private readonly IConfiguration _configuration;

        public LoginController(UserManager<AspNetUser> userManager, SignInManager<AspNetUser> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO login)
        {

            /* Böyle bir kullanıcı var mı buna baktık */
            var user = await _userManager.FindByNameAsync(login.UserName);
            if (user == null)
                return Unauthorized();

            /* Kullanıcı var, şimdi şifresi doğru mu bunu kontrol edicez.*/

            PasswordHasher<AspNetUser> passwordHasher = new PasswordHasher<AspNetUser>();

            var result = passwordHasher.VerifyHashedPassword(user, user.PasswordHash, login.Password);
            if (result != PasswordVerificationResult.Success)
                return Unauthorized();

            /* JWT Token oluştur ve gönder. */
            string strToken = GetToken(user.Email);
            return Ok(strToken);
        }

        private string GetToken(string email)
        {
            var authClaims = new List<Claim>
            {
                    new Claim(ClaimTypes.Email, email)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:secretKey"]));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                                authClaims.ToString(),
                                expires: DateTime.UtcNow.AddMinutes(10),
                                signingCredentials: signIn);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
