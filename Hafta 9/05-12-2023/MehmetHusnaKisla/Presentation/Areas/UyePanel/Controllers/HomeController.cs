using AutoMapper;
using MehmetHusnaKisla.Application.Models.DTOs;
using MehmetHusnaKisla.Application.Services.AppUserService;
using MehmetHusnaKisla.Application.Services.EssayService;
using MehmetHusnaKisla.Application.Services.TopicService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Presentation.Models.VMs;

namespace Presentation.Areas.UyePanel.Controllers
{
    [Area("UyePanel")]
    [Authorize(Roles = "Uye")]
    public class HomeController : Controller
    {
        private readonly IEssayService _essayService;
        private readonly ITopicService _topicService;
        private readonly IAppUserService _userService;
        private readonly IMapper _mapper;

        public HomeController(IEssayService essayService, ITopicService topicService, IAppUserService userService, IMapper mapper)
        {
            _essayService= essayService;
            _topicService = topicService;
            _userService = userService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            EssayInsertVM essayInsertVM = new EssayInsertVM();
            essayInsertVM.Topics = new SelectList(await _topicService.GetAllActiveTopics(), "TopicID", "TopicName");

            return View(essayInsertVM);
        }

        [HttpPost]
        public async Task<IActionResult> EssayInsert(EssayInsertVM essayInsertVM)
        {
            EssayInsertDTO essayInsertDTO = new EssayInsertDTO();
            essayInsertDTO.EssayName = essayInsertVM.EssayName;
            essayInsertDTO.EssayContent = essayInsertVM.EssayName;
            essayInsertDTO.TopicID = essayInsertVM.TopicID;
            essayInsertDTO.PublisherID = _userService.GetUserId(User);

            await _essayService.InsertEssay(essayInsertDTO);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> EssayList()
        {
            return View(await _essayService.ListActiveEssays());
        }

        public async Task<IActionResult> EssayDetail(int id)
        {
            return View(await _essayService.GetEssay(id));
        }
    }
}
