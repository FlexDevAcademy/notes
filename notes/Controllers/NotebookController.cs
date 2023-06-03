using Microsoft.AspNetCore.Mvc;
using notes.Models;
namespace notes.Controllers
{
    public class NotebookController : Controller
    {


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

