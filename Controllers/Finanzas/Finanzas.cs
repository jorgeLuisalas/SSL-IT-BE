using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndWaffles.Controllers.Finanzas
{
    public class Finanzas : Controller
    {
        // GET: Finanzas
        public ActionResult Index()
        {
            return View();
        }

        // GET: Finanzas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Finanzas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Finanzas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Finanzas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Finanzas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Finanzas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Finanzas/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
