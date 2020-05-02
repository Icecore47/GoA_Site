using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GoA_Site.Models;

namespace GoA_Site.Controllers
{
    public class TankController : Controller
    {
        private readonly Fire FS = new Fire();

   
        public async Task<ActionResult> Index()
        {

            IEnumerable<Tank> x = await FS.GetGuildTanks();
            
            
            return View(x);
        }

        // GET: Tank/Details/5
        public async Task<ActionResult> Details(String id)
        {

            var Guildie = await FS.GetGuildTank(id);
            return View(Guildie);
           
        }

        // GET: Tank/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tank/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection)
        {

            string ign = Convert.ToString(collection["InGameName"]);
            string name = Convert.ToString(collection["CharacterName"]);
            string clas = Convert.ToString(collection["Class"]);
           
        
            try
            {
                var newTank = new Tank(ign,name,clas);
                var TankGear = new TankGear(ign);
                await FS.AddNewTank(newTank);
                await FS.AddNewTankGear(TankGear);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                var y = e;
                return View();
            }
        }

        // GET: Tank/Edit/5
        public async Task<ActionResult> Edit(String id)
        {
            var Guildie = await FS.GetGuildTank(id);
            return View(Guildie);
        }

        // POST: Tank/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, IFormCollection collection)
        {
            string ign = Convert.ToString(collection["InGameName"]);
            string name = Convert.ToString(collection["CharacterName"]);  
            string clas = Convert.ToString(collection["Class"]);
            try
            {
                var newTank = new Tank(ign,name,clas);
                await FS.AddNewTank(newTank);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Tank/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            var Guildie = await FS.GetGuildTank(id);
            return View(Guildie);
        }

        // POST: Tank/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(String id, IFormCollection collection)
        {
            try
            {
                await FS.DeleteGuildTank(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}