using Jungle_DataAccess.Repository.IRepository;
using Jungle_Models;
using Microsoft.AspNetCore.Mvc;

namespace Jungle_Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TravelRecommendationController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CountryController> _logger;

        public TravelRecommendationController(IUnitOfWork unitOfWork, ILogger<CountryController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public IActionResult Index()
        {
            IEnumerable<TravelRecommendation> TravelRecommendationList = _unitOfWork.TravelRecommendation.GetAll();

            return View(TravelRecommendationList);
        }

        public IActionResult Upsert(int? id)
        {
            TravelRecommendation travelRecommendation = new TravelRecommendation();
            if (id == null)
            {
                // Create
                return View(travelRecommendation);
            }
            // Update
            travelRecommendation = _unitOfWork.TravelRecommendation.Get(id.GetValueOrDefault());
            if (travelRecommendation == null)
            {
                return NotFound();
            }
            return View(travelRecommendation);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(TravelRecommendation travelRecommendation)
        {
            if (ModelState.IsValid)
            {
                if (travelRecommendation.Id == 0)
                {
                    _unitOfWork.TravelRecommendation.Add(travelRecommendation);

                }
                else
                {
                    _unitOfWork.TravelRecommendation.Update(travelRecommendation);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(travelRecommendation);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var travelRecommendation = _unitOfWork.TravelRecommendation.Get(id.GetValueOrDefault());
            if (travelRecommendation == null)
            {
                return NotFound();
            }

            return View(travelRecommendation);
        }

        //POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var travelRecommendation = _unitOfWork.TravelRecommendation.Get(id.GetValueOrDefault());
            if (travelRecommendation == null)
            {
                return NotFound();
            }
            TempData["Success"] = "Delete completed successfully";
            _unitOfWork.TravelRecommendation.Remove(travelRecommendation);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }

    }
}

