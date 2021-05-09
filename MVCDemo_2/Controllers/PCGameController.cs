using MVCDemo_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo_2.Controllers
{
    public class PCGameController : Controller
    {
        // GET: PCGame
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PCGameList()
        {
            List<PCGameModel> games = new List<PCGameModel>();

            games.Add(new PCGameModel { Title = "Dawn of War 3", Genre = "RTS", Developer = "Relic", Publisher = "SEGA", ReleaseDate = 2017, MultiPlayer = true });
            games.Add(new PCGameModel { Title = "Anno 2070", Genre = "Strategy", Developer = "Ubisoft", Publisher = "BlueByte", ReleaseDate = 2012, MultiPlayer = true });
            games.Add(new PCGameModel { Title = "Tomb Raider", Genre = "Action", Developer = "Steam", Publisher = "Steam", ReleaseDate = 2015, MultiPlayer = false });
            games.Add(new PCGameModel { Title = "Diablo 3", Genre = "Action RPG", Developer = "Blizzard", Publisher = "Blizzard", ReleaseDate = 2012, MultiPlayer = true });
            games.Add(new PCGameModel { Title = "Crysis 2", Genre = "Ego Shooter", Developer = "Crytek", Publisher = "Crytek", ReleaseDate = 2012, MultiPlayer = true });
            return View();
        }
    }
}