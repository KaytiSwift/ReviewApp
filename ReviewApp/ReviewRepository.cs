using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReviewApp.Models;

namespace ReviewApp
{
    public class ReviewRepository : IReviewRepository
    {
        Dictionary<int, Review> all = new Dictionary<int, Review>()
            {
                {
                    1, new Review()
                    {
                        ID = 1,
                        Title ="Venom",
                        ImageURL ="https://cnet1.cbsistatic.com/img/FYGAjiXg3fot20UbN9dgC1xYUyI=/1600x900/2018/10/03/84c857e6-d5b5-4ee9-9052-e9d3822b24b0/venom-poster-new-1200-1703-81-s.jpg",
                        ReviewCategory="Action",
                        Content="This movie sucked!"
                    }

                },
                {
                    2, new Review()
                    {
                        ID = 2,
                        Title = "Harry Potter and the Philosopher's Stone",
                        ImageURL = "https://mvpo.us/img/P5159.jpg",
                        ReviewCategory = "Fantasy",
                        Content = "Best movie EVER!!!"
                    }
                },
                {
                    3, new Review()
                    {
                        ID = 3,
                        Title = "Gardians of the Galaxy",
                        ImageURL = "https://is5-ssl.mzstatic.com/image/thumb/Video128/v4/14/e5/e6/14e5e6d9-55a2-7aa1-ffc6-e0cfe10b404c/contsched.iciryzrt.lsr/268x0w.jpg",
                        ReviewCategory = "Sci-Fi",
                        Content = "Hilarious! A must see movie!"
                    }
                }
            };

        public List<Review> GetAll()
        {            
            return all.Values.ToList();
        }

        public Review FindByID(int id)
        {
            return all[id];
        }
    }
}
