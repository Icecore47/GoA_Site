using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GoA_Site.Models;

namespace GoA_Site.Controllers
{
    public class HealerController : Controller
    {
        private readonly Fire FS = new Fire();

   
        public async Task<ActionResult> Index()
        {

            IEnumerable<Healer> x = await FS.GetGuildDDs();
            
            
            return View(x);
        }

        // GET: Healer/Details/5
        public async Task<ActionResult> Details(String id)
        {

            var Guildie = await FS.GetGuildHealer(id);
            return View(Guildie);
           
        }

        // GET: Healer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Healer/Create
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
                var newHealer = new Healer(ign, name, dps, type, clas, parse);
                await FS.AddNewDD(newHealer);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                var y = e;
                return View();
            }
        }

        // GET: Healer/Edit/5
        public async Task<ActionResult> Edit(String id)
        {
            var Guildie = await FS.GetGuildHealer(id);
            return View(Guildie);
        }

        // POST: Healer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, IFormCollection collection)
        {
            string ign = Convert.ToString(collection["InGameName"]);
            string name = Convert.ToString(collection["CharacterName"]);  
            string clas = Convert.ToString(collection["Class"]);
            try
            {
                var newHealer = new Healer(ign,name,clas);
                await FS.AddNewDD(newHealer);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Healer/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            var Guildie = await FS.GetGuildHealer(id);
            return View(Guildie);
        }

        // POST: Healer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(String id, IFormCollection collection)
        {
            try
            {
                await FS.DeleteGuildHealer(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}