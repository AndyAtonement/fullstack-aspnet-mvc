using BeeEngineering.Models;
using BeeEngineering.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BeeEngineering.Controllers
{
    public class CandidatesController : Controller
    {

        private readonly ICandidatesRepository _candidatesRepository;

        public CandidatesController(ICandidatesRepository candidatesRepository)
        {
            _candidatesRepository = candidatesRepository;
        }
        public IActionResult Index()
        {
            List<CandidateModel> candidates = _candidatesRepository.GetAll();
            return View(candidates);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Update(int id)
        {
            CandidateModel candidate = _candidatesRepository.GetById(id);
            return View(candidate);
        }

        public IActionResult DeleteConfirmation(int id)
        {
            CandidateModel candidate = _candidatesRepository.GetById(id);
            return View(candidate);
        }

        public IActionResult Delete(int id)
        {
            try
            {
                bool deleted = _candidatesRepository.Delete(id);

                if (deleted) TempData["SucessMessage"] = "Cadidate deleted!"; else TempData["ErrorMessage"] = "Unexpected error deleting a candidadte";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Unexpected error deleting a candidadte {ex.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Create(CandidateModel candidate)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _candidatesRepository.Create(candidate);
                    TempData["SuccessMessage"] = "Sucess registering the candidate";
                    return RedirectToAction("Index");
                }
                return View(candidate);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Unexpected error registering the candidate {ex.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Update(CandidateModel candidate)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _candidatesRepository.Update(candidate);
                    TempData["SucessMEssage"] = "Success Updating a candidate";
                    return RedirectToAction("Index");
                }
                return View(candidate);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Unexpected Error updating a candidate {ex.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
