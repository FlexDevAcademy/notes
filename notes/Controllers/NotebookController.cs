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
            return View();
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

        public async Task<IActionResult> Edit(int id)
        {
            return View();
        }

        public async Task<IActionResult> Edit(Note note)
        {
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            return View();
        }
    }
}

