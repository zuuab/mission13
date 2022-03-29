using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using mission13.Models;

namespace mission13.Components
{
    public class TeamsViewComponent : ViewComponent
    {
        private ITeamsRepository repo { get; set; }

        public TeamsViewComponent (ITeamsRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData?.Values["teamID"];

            var teams = repo.Teams
                .Select(x => x)
                .Distinct()
                .OrderBy(x => x);

            return View(teams);
        }
    }
}
