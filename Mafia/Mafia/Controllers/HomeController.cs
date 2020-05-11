using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mafia.Models;

namespace Mafia.Controllers
{
    public class HomeController : Controller
    {
        Brain b = new Brain();
        public ActionResult Index()
        {
            return View();
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

        public ActionResult GetCards(string userName, bool komisar,bool doc, bool prostitute, List<string> users)
        {
            int numUsers = users.Count;
            List<Card> deck = b.BuildDeck(numUsers, doc,komisar, prostitute, users);
            ViewData["MafiaDeck"] = deck;
            return View();
        }
    }
}