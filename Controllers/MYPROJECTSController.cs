using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TMC.Models;

namespace TMC.Controllers
{
    public class MYPROJECTSController : Controller
    {
        TMCDB db = new TMCDB();
        mytasks Mytasks;
        public IActionResult Index()
        {
            var list = db.Myprojects.ToList();
            return View(list);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(myprojects myprojects)
        {
            db.Myprojects.Add(myprojects);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        public ActionResult Update(int id)
        {
            var updated = db.Myprojects.FirstOrDefault(x => x.Id == id);
            if (updated != null)
            {
                return View(updated);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        public ActionResult Update(myprojects myprojects)
        {
            db.Myprojects.Update(myprojects);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var Deleted = db.Myprojects.FirstOrDefault(x => x.Id == id);
            if (Deleted != null)
            {
                db.Myprojects.Remove(Deleted);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return NotFound();
            }
        }
    }
}
