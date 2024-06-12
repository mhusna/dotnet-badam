using MehmetHusnaKisla.Application.Models.DTOs.Topic;
using MehmetHusnaKisla.Application.Services.AppUserService;
using MehmetHusnaKisla.Application.Services.TopicService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Presentation.Models.DTOs;
using System.Data;

namespace Presentation.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private readonly ITopicService _topicService;
        private readonly IAppUserService _appUserService;

        public HomeController(ITopicService topicService, IAppUserService appUserService)
        {
            _topicService = topicService;
            _appUserService = appUserService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> TopicInsert(TopicInsertPLDTO topicInsertPLDTO)
        {
            TopicInsertDTO topicInsertDTO = new TopicInsertDTO();
            topicInsertDTO.TopicName = topicInsertPLDTO.TopicName;
            topicInsertDTO.InserterID = _appUserService.GetUserId(User);

            await _topicService.TopicInsert(topicInsertDTO);
            return RedirectToAction("ListTopics");
        }

        public async Task<IActionResult> ListTopics()
        {
            return View(await _topicService.GetAllTopics());
        }
    }
}
