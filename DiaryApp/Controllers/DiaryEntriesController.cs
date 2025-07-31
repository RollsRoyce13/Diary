using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DiaryEntriesController(ApplicationDbContext db) // Get ApplicationDbContext from Program.cs Services
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<DiaryEntry> objDiaryEntryList = _db.DiaryEntries.ToList(); // Get all entries from the database

            return View(objDiaryEntryList); // Return the list of diary entries to the view
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost] // This attribute indicates that this method will handle POST requests
        public IActionResult Create(DiaryEntry obj)
        {
            _db.DiaryEntries.Add(obj); // Add the new diary entry to the database
            _db.SaveChanges(); // Save changes to the database

            return RedirectToAction("Index"); // Redirect to the Index action after creating a new entry
        }
    }
}
