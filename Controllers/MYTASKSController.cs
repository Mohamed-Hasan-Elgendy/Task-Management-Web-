using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TMC.Models;

namespace TMC.Controllers
{
    public class MYTASKSController : Controller
    {
        TMCDB db = new TMCDB();
        myteammember Myteammember;
        myprojects myprojects;
        public IActionResult Index()
        {
            var list = db.Mytasks.ToList();
            return View(list);
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(mytasks mytasks)
        {
            db.Mytasks.Add(mytasks);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        public ActionResult Update(int id) 
        {
           var updated = db.Mytasks.FirstOrDefault(x => x.Id == id);
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
        public ActionResult Update(mytasks mytasks)
        {
            db.Mytasks.Update(mytasks); 
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id) 
        {
            var updated = db.Mytasks.FirstOrDefault(x => x.Id == id);
            if (updated != null)
            {
               db.Mytasks.Remove(updated);
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
