using Microsoft.AspNetCore.Mvc;
using notes.Models;
using notes.Services;

namespace notes.Controllers
{
    public class NotebookController : Controller
    {
        private readonly INoteService _db;

        public NotebookController(INoteService db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await _db.GetAll();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Note note)
        {
            if (ModelState.IsValid)
            {
                await _db.Add(note);
                return RedirectToAction("Index");
                
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await _db.Get(id);

            return View(model);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Note note)
        {
            if (ModelState.IsValid)
            {
                await _db.Update(note);

                return RedirectToAction("Index");
            }

            return View(note);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {

            var model = await _db.Get(id);

            if (model == null)
            {
                return View("NotFound");
            }

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, IFormCollection form)
        {
            await _db.Delete(id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<ActionResult> Details(int id)
        {
            var model = await _db.Get(id);

            if (model == null)
            {
                return View("NotFound");
            }

            return View(model);

        }
    }
}

