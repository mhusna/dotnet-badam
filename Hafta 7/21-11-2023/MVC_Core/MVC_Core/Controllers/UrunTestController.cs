using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Core.Controllers
{
    public class UrunTestController : Controller
    {
        // GET: UrunTestController
        public ActionResult Index()
        {
            return View();
        }

        // GET: UrunTestController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UrunTestController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UrunTestController/Create
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

        // GET: UrunTestController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UrunTestController/Edit/5
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

        // GET: UrunTestController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UrunTestController/Delete/5
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
