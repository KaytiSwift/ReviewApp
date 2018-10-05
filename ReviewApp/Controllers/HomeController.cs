using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewApp.Controllers
{
    public class HomeController : Controller
    {
        private IReviewRepository reviewRepo;

        public HomeController(IReviewRepository reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }

        public ViewResult Index()
        {
            reviewRepo.GetAll();
            return View();
        }
    }

    
}
