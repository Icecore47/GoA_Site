using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Google.Cloud.Firestore.V1;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GoA_Site.Models;

namespace GoA_Site.Controllers
{
    public class GuildMemberController : Controller
    {
        private readonly Fire FS = new Fire();   

        // GET: GuildMember
        public async Task<ActionResult> Index()
        {
            var y = await  FS.GetGuildMembers();
            return View(y);
        }

        // GET: GuildMember/Details/5
        public async Task<ActionResult> Details(string id)
        {
            var Guildie = await FS.GetGuildMember(id);
            return View(Guildie);
        }

        // GET: GuildMember/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GuildMember/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection)
        {

            string ign = Convert.ToString(collection["InGameName"]);
            string rank = Convert.ToString(collection["Guild_Rank"]);
            string discord_id = Convert.ToString(collection["Discord_ID"]);
            string discord_name = Convert.ToString(collection["Discord_Name"]);
            DateTime date = Convert.ToDateTime(collection["JoinDate"]);

            try
            {
                var y = new GuildMember(ign, rank, discord_id, discord_name, date);
                var x = new GuildMemberDTO(y);
                await FS.AddNewGuildMember(x);

                return RedirectToAction("GuildMember","Index");
            }
            catch(Exception e)
            {
                var y = e;
                return View();
            }
        }

        // GET: GuildMember/Edit/5
        public async Task<ActionResult> Edit(String id)
        {
            var Guildie = await FS.GetGuildMember(id);

            return View(Guildie);
        }

        // POST: GuildMember/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, IFormCollection collection)
        {
            string ign = Convert.ToString(collection["InGameName"]);
            string rank = Convert.ToString(collection["Guild_Rank"]);
            string discord_id = Convert.ToString(collection["Discord_ID"]);
            string discord_name = Convert.ToString(collection["Discord_Name"]);
            DateTime date = Convert.ToDateTime(collection["JoinDate"]);

            try
            {
                var y = new GuildMember(ign, rank, discord_id, discord_name, date);
                var x = new GuildMemberDTO(y);
                await FS.AddNewGuildMember(x);

                return RedirectToAction("GuildMember", "Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: GuildMember/Delete/5
        public async Task<ActionResult> DeleteAsync(string id)
        {

            var Guildie = await FS.GetGuildMember(id);
            return View(Guildie);
        }

        // POST: GuildMember/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(String id, IFormCollection collection)
        {
            try
            {
                await FS.DeleteGuildMember(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}