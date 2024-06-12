using Microsoft.AspNetCore.Mvc;
using WebClient.Models;
using Newtonsoft.Json;

namespace WebClient.Controllers
{
    public class TestController : Controller
    {
        static string jwt = null;
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login login)
        {
            HttpClient client = new HttpClient();

            var response = await client.PostAsJsonAsync("http://localhost:5240/api/Login", login);

            /* Burası kesinlikle böyle kalmalı */
            jwt = "Bearer " + await response.Content.ReadAsStringAsync();
            return Content("Token: " + jwt);
        }

        public async Task<IActionResult> GetFilms()
        {
            HttpClient client = new HttpClient();

            /* Onemli */
            /* Json data'sı gönderdiğimizi söyledik. */
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            /* Token'ı kullanacağını söylüyoruz. */
            client.DefaultRequestHeaders.Add("Authorization", jwt);

            string strJSON = await client.GetStringAsync("http://localhost:5240/api/Filmlers");

            /* NewtonSoft kullanımı */
            var filmler = JsonConvert.DeserializeObject<List<Film>>(strJSON);

            return View(filmler);
        }
    }
}
