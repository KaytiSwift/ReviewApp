using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReviewApp.Models;

namespace ReviewApp
{
    public class ReviewRepository : IReviewRepository
    {
        public ReviewRepository()
        {
            //default constructor
        }

        Dictionary<int, Review> all = new Dictionary<int, Review>()
            {
                {
                    1, new Review()
                    {
                        ID = 1,
                        Title ="Venom",
                        ImageURL ="/images/Venom.jpg",
                        ReviewCategory="Action",
                        Content="The critics said this movie sucked! I haven't seen it yet but Neko said it was awesome! I guess I need to go see it myself.",
                        AltPicText = "Venom"
                    }

                },
                {
                    2, new Review()
                    {
                        ID = 2,
                        Title = "Harry Potter and the Philosopher's Stone",
                        ImageURL = "/images/HarryPotter.jpg",
                        ReviewCategory = "Fantasy",
                        Content = "Best movie EVER!!! Based on the best book series ever! I love this movie. Go watch it if you haven't.",
                        AltPicText = "Harry Potter"
                    }
                },
                {
                    3, new Review()
                    {
                        ID = 3,
                        Title = "Guardians of the Galaxy",
                        ImageURL = "/images/Guardians.jpg",
                        ReviewCategory = "Sci-Fi",
                        Content = "Hilarious! A must see movie! High quality writing just like every other MCU movie. If they don't make a third one, my heart will break.",
                        AltPicText = "Guardians"
                    }
                }
            };

        public List<Review> GetAll()
        {            
            return all.Values.ToList();
        }

        public Review FindById(int id)
        {
            return all[id];
        }
    }
}
