using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GoA_Site.Models;

namespace GoA_Site.Controllers
{
    public class DamageController : Controller
    {
        private readonly Fire FS = new Fire();

   
        public async Task<ActionResult> Index()
        {

            IEnumerable<Damage> x = await FS.GetGuildDDs();
            
            
            return View(x);
        }

        // GET: Damage/Details/5
        public async Task<ActionResult> Details(String id)
        {

            var Guildie = await FS.GetGuildDamage(id);
            return View(Guildie);
           
        }

        // GET: Damage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Damage/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection)
        {

            string ign = Convert.ToString(collection["InGameName"]);
            string name = Convert.ToString(collection["CharacterName"]);
            string type = Convert.ToString(collection["Type"]);
            string clas = Convert.ToString(collection["Class"]);
            Double dps = Convert.ToDouble(collection["DPS"]);
            string parse = Convert.ToString(collection["Parse"]);
            try
            {
                var newDamage = new Damage(ign, name, dps, type, clas, parse);
                await FS.AddNewDD(newDamage);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                var y = e;
                return View();
            }
        }

        // GET: Damage/Edit/5
        public async Task<ActionResult> Edit(String id)
        {
            var Guildie = await FS.GetGuildDamage(id);
            return View(Guildie);
        }

        // POST: Damage/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, IFormCollection collection)
        {
            string ign = Convert.ToString(collection["InGameName"]);
            string name = Convert.ToString(collection["CharacterName"]);
            string type = Convert.ToString(collection["Type"]);
            string clas = Convert.ToString(collection["Class"]);
            Double dps = Convert.ToDouble(collection["DPS"]);
            string parse = Convert.ToString(collection["Parse"]);
            try
            {
                var newDamage = new Damage(ign, name, dps, type, clas, parse);
                await FS.AddNewDD(newDamage);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Damage/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Damage/Delete/5
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