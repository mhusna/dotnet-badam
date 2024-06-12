using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_I.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaslangicController : ControllerBase
    {
        [HttpGet]
        public string Test()
        {
            return "Test -- Web API..";
        }

        [HttpGet("dene")]
        public string Deneme()
        {
            return "Deneme -- Web API..";
        }

        #region 1- Return Type: Void

        [HttpPost]
        public void VeriAl(string mesaj)
        {
            Console.WriteLine($">> {mesaj}");
        }

        #endregion

        #region 2- Return Type: Collection

        [HttpGet("sehirler")]
        public List<string> TumSehirler()
        {
            return new List<string> { "İstanbul", "Bursa", "Ankara", "Zonguldak", "Izmir" };
        }

        #endregion

        #region 3- Return Type: HttpResponseMessage

        [HttpGet("test2")]
        public HttpResponseMessage Test2()
        {
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        }

        #endregion

        #region 4- Return Type: IActionResult

        [HttpGet("test3")]
        public IActionResult Test3()
        {
            //return Ok();
            //return Unauthorized();
            return BadRequest();
        }

        #endregion
    }
}
