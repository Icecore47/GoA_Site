using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoA_Site.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GoA_Site.Controllers
{
    
    public class TankGearController : Controller
    {
        private readonly Fire FS = new Fire();
        // GET: TankGear
        public async Task<ActionResult> Index()
        {
            IEnumerable<TankGear> x = await FS.GetAllTankGear();
            return View(x);
        }

        // GET: TankGear/Details/5
        public async Task<ActionResult> Details(string id)
        {
            var x = await FS.GetTankGear(id);
            return View(x);
        }

      

        // GET: TankGear/Edit/5
        public async Task<ActionResult> Edit(String id)
        {
            var x = await FS.GetTankGear(id);
            return View(x);

        }

        // POST: TankGear/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: TankGear/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}