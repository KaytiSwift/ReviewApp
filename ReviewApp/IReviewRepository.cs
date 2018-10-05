using ReviewApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewApp
{
    public interface IReviewRepository
    {
        List<Review> GetAll();
    }
}
