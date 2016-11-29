using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreWeb2015r2.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreWeb2015r2.Controllers
{
    public class MeetingController : Controller
    {
        // GET: /<controller>/
        private ApplicationDbContext ctx = new ApplicationDbContext();
        public IActionResult Index()
        {
            var conference = ctx.Conferences.Include( c=>c.Sessions).First();
            return View(conference);
        }

        public IActionResult CreateConference()
        {
            var conference = new Conference
            {
                Name = "Park Summit",
                TicketPrice = 250.00m
            };

            ctx.Conferences.Add(conference);
            ctx.SaveChanges();
            var sessionTitles = new List<string>
            {
                "Horse Riding", "Fishing", "Hiking"
            };
            foreach (var title in sessionTitles)
            {
                var session = new Session {
                     Conference = conference,
                     Title = title
                };

                ctx.Sessions.Add(session);
                ctx.SaveChanges();
            }

            return RedirectToAction("Index", "Meeting");
        }
    }
}
