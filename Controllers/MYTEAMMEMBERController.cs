using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TMC.Models;

namespace TMC.Controllers
{
    public class MYTEAMMEMBERController : Controller
    {
        TMCDB db = new TMCDB();
        public IActionResult Details()
        {
            var list = db.Myteammembers.ToList();
            return View(list);
        }
        public ActionResult Update(int id)
        {
            var updated = db.Myteammembers.FirstOrDefault(x => x.Id == id);
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
        public ActionResult Update(myteammember myteammember)
        {
            db.Myteammembers.Update(myteammember);
            db.SaveChanges();
            return RedirectToAction(nameof(Details));
        }
    }
}
