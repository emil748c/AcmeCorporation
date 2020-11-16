using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application;
using Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using X.PagedList;

namespace AcmeCorporation.Controllers
{
    [Route("api/[controller]/[action]")]
    //[ApiController]
    public class SubmissionController : Controller
    {
        private readonly ISubmissionService service;

        public SubmissionController(ISubmissionService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int? page)
        {
            var submissions = await service.GetAllSubmissions();

            var pageNumber = page ?? 1;
            var onePageOfSubmissions = submissions.ToPagedList(pageNumber, 10);

            ViewBag.OnePageOfSubmissions = onePageOfSubmissions;
            return View(onePageOfSubmissions);
        }

        [HttpGet]
        public async Task<IActionResult> CreateSubmission()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSubmission(CreateSubmissionViewModel viewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            await service.CreateSubmission(viewModel);
            return RedirectToAction("Index", "Home");
        }
    }
}
