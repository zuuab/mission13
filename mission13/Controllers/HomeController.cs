using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mission13.Models;

namespace mission13.Controllers
{
    public class HomeController : Controller
    {

        private IBowlersRepository _repo { get; set; }

        public HomeController(IBowlersRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int teamID = 0)
        {
            var blah = _repo.Bowlers
                .Where(x => x.TeamID == teamID || teamID == 0)
                .OrderBy(x => x.BowlerLastName)
                .ToList();
            return View(blah);
        }

        [HttpGet]
        public IActionResult Add(Bowler model)
        {
            return View("EditAddBowler", model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var bowler = _repo.Bowlers
                .Single(x => x.BowlerID == id);

            return View("EditAddBowler", bowler);
        }

        [HttpPost]
        public IActionResult EditAddBowler(Bowler bowler)
        {
            if (ModelState.IsValid)
            {
                if (bowler.BowlerID == 0)
                {
                    _repo.Add(bowler);
                    return RedirectToAction("Index");
                }
                else
                {
                    _repo.Save(bowler);
                    return RedirectToAction("Index");
                }
            }
            else
            {
                return View("EditAddBowler");
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Bowler bowler = _repo.Bowlers
                .FirstOrDefault(x => x.BowlerID == id);

            return View("Delete", bowler);
        }

        [HttpPost]
        public IActionResult Delete(Bowler bowler)
        {
            _repo.Delete(bowler);

            return RedirectToAction("Index");
        }
    }
}
