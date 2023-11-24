using Blog.Models;
using Blog.Services.Posts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Blog.Data.Common;
using System.Diagnostics;

namespace Blog.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository repo;
        private readonly IPostService postService;

        public HomeController(ILogger<HomeController> logger, IRepository repo, IPostService postService)
        {
            this.repo = repo;
            _logger = logger;
            this.postService = postService;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Landing()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await postService.GetAllAsync());
        }

    }
}