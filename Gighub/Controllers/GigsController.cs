using System;
using System.Linq;
using System.Web.Mvc;
using Gighub.Models;
using Gighub.ViewModels;
using Microsoft.AspNet.Identity;

namespace Gighub.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        // GET: Gigs
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };
            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(GigFormViewModel viewModel)
        {
            _context.Gigs.Add(
                new Gig
            {
                ArtistId = User.Identity.GetUserId(),
                DateTime = viewModel.DateTime,
                Venue = viewModel.Venue,
                GenreId= viewModel.Genre
            });

            _context.SaveChanges();
            return RedirectToAction("Index","Home"); 
        }
    }
}