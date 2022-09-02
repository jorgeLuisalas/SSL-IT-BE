using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndWaffles.Controllers.Inicio
{
    public class Inicio : Controller
    {
        // GET: Inicio
        public ActionResult Index()
        {
            return View();
        }

        // GET: Inicio/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Inicio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Inicio/Create
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

        // GET: Inicio/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Inicio/Edit/5
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

        // GET: Inicio/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Inicio/Delete/5
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
