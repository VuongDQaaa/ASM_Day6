using Microsoft.AspNetCore.Mvc;
using ASM_Day6.Services;
using System.Data;
using ASM_Day6.Models;
using ClosedXML.Excel;
namespace ASM_Day6.Controllers
{
    public class MemberController : Controller
    {
        private readonly IMemberservice _memberService;
        private readonly ILogger<MemberController> _logger;
        public MemberController(ILogger<MemberController> logger, IMemberservice memberservice)
        {
            _logger = logger;
            _memberService = memberservice;
        }
        public IActionResult Index()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
        public IActionResult Read()
        {
            var data = _memberService.GetAllMember();
            return View(data);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Member member)
        {
            _memberService.AddMember(member);
            return RedirectToAction("Read");
        }
        public IActionResult Update(int id)
        {
            var data = _memberService.FindByID(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Update(Member member)
        {
            _memberService.UpdateMember(member);
            return RedirectToAction("Read");
        }
        public IActionResult Delete(int id)
        {
            _memberService.DeleteMember(id);
            return RedirectToAction("Read");
        }

    }
}