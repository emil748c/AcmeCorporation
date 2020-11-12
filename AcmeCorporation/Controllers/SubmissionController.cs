using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application;
using Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace AcmeCorporation.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SubmissionController : Controller
    {
        private readonly ISubmissionService service;

        public SubmissionController(ISubmissionService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var submissions = await service.GetAllSubmissions();
            return View(submissions);
        }

        [HttpGet]
        public async Task<IActionResult> CreateSubmission()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateASubmission(CreateSubmissionViewModel viewModel)
        {
            await service.CreateSubmission(viewModel);
            return Ok();
        }
    }
}
