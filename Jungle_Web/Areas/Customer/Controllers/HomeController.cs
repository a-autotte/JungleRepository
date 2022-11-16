using Jungle_DataAccess.Repository.IRepository;
using Jungle_Models;
using Jungle_Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Jungle.Controllers
{
  [Area("Customer")]
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
        private IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
    {
            IEnumerable<Travel> TravelList = _unitOfWork.Travel.GetAll(includeProperties: "TravelRecommendation").Where(p => p.DepartureDate >= DateTime.Today.AddDays(14));
            return View(TravelList);
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
