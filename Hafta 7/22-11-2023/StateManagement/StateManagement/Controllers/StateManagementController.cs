using Microsoft.AspNetCore.Mvc;

namespace StateManagement.Controllers
{
    public class StateManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        #region Ders 1: Cookie Olusturma ve Okuma
        public IActionResult CreateCookie()
        {
            // Cookie oluşturma..
            //Response.Cookies.Append("cerezos", "Hello Cookie!!");

            // Cookie'lere yaşam süresi verme.
            Response.Cookies.Append("cerezos", "Hello Cookie!!", new CookieOptions { Expires = DateTime.Now.AddDays(15)});
            return Content("Creates a cookie.");
        }

        public IActionResult ReadFromCookie()
        {
            // Null değer kontrollü
            //string cookieValue;
            //Request.Cookies.TryGetValue("cerezos", out cookieValue);

            return Content("Cookie value: "+Request.Cookies["cerezos"]);
        }
        #endregion

        #region Ders 2: Session
        public IActionResult CreateSession()
        {
            HttpContext.Session.SetString("Mesaj", "Hello Session.."+DateTime.Now.ToLongTimeString());
            return Content("Session oluştu..");
        }

        public IActionResult ReadFromSession()
        {
            string mesaj = HttpContext.Session.GetString("Mesaj");
            return Content("Session verisi: "+mesaj);
        }
        #endregion
    }
}
