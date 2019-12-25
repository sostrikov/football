using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Football.Models;
using System.Data.Entity;

namespace Football.Controllers
{
    public class HomeController : Controller
    {
        FootballContext db = new FootballContext();
        // Выводим всех футболистов
        public ActionResult Index()
        {
            var players = db.Players.Include(p => p.Team);
            return View(players.ToList());
        }

        public ActionResult TeamDetails(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Team team = db.Teams.Include(t => t.Players).FirstOrDefault(t => t.Id == id);
            if (team == null)
            {
                return HttpNotFound();
            }
            return View(team);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}