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

        public async Task<IActionResult> Create()
        {
            return View();
        }

        public async Task<IActionResult> Edit()
        {
            return View();
        }

        public async Task<IActionResult> Delete()
        {
            return View();
        }
    }
}
