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
    }
}
