using Laboratorio5.Services.Utenti;
using Laboratorio5.Web.Features.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Laboratorio5.Web.Features.Home
{
    public partial class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, UtentiService utentiService) : base(utentiService)
        {
            _logger = logger;
        }

        public virtual IActionResult Index()
        {
            return View();
        }

        public virtual IActionResult Privacy()
        {
            return View();
        }
    }
}