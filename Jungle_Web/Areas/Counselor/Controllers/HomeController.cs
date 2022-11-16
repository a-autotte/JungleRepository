using Jungle_DataAccess.Repository.IRepository;
using Jungle_Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jungle.Areas.Counselor.Controllers
{
  [Area("Counselor")]
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfwork;

    public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
    {
            _unitOfwork = unitOfWork;
            _logger = logger;
    }

    public IActionResult Index()
    {
      return View();
    }
        public IActionResult Edit(int id)
        {
            Travel travel = _unitOfwork.Travel.FirstOrDefault(t => t.Id == id);
            return View(travel);
        }

  }
}
