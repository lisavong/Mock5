using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mock5.Controllers
{
    public class GetAgeController : Controller
    {
        // GET: GetAgeController
        public ActionResult Index()
        {
            return View();
        }
        

        // GET: GetAgeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GetAgeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GetAgeController/Create
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

        // GET: GetAgeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GetAgeController/Edit/5
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

        // GET: GetAgeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GetAgeController/Delete/5
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
