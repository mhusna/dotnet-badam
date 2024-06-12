using MehmetHusnaKisla.Application.Services.EssayService;
using MehmetHusnaKisla.Application.Services.TopicService;
using Microsoft.AspNetCore.Mvc;
using Presentation.Models;
using System.Diagnostics;

namespace Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITopicService _topicService;
        private readonly IEssayService _essayService;
        public HomeController(ILogger<HomeController> logger, ITopicService topicService, IEssayService essayService)
        {
            _logger = logger;
            _topicService = topicService;
            _essayService = essayService;
        }

        public async Task<IActionResult> Index()
        {

            Console.WriteLine(await _essayService.EssayCount());
            Console.WriteLine(await _topicService.TopicCount());
            ViewBag.EssayCount = await _essayService.EssayCount();
            ViewBag.TopicCount = await _topicService.TopicCount();



            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
