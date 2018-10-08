using ReviewApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewApp
{
    public interface IReviewRepository
    {
        //Getall method returns a list of reviews
        List<Review> GetAll();

        //findbyid method returns a review
        Review FindById(int id);
    }
}
