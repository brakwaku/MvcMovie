using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Mobsters and Mormons",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        GenreId = 1,
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/6/62/MobMormon.jpg",
                        Rating = "PG",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "The Best Two Years",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        GenreId = 3,
                        ImageUrl = "https://www.livingscriptures.com/wp-content/uploads/2019/11/2f4eeb1264d20645ed3a3cdb7c3ff6025eebe30f.jpg",
                        Rating = "PG",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        GenreId = 2,
                        ImageUrl = "https://moviereviewmom.com/wp-content/uploads/2019/07/The-Other-Side-of-Heaven-2-movie-poster.jpg",
                        Rating = "PG",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Singles Ward",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        GenreId = 4,
                        ImageUrl = "https://i.ebayimg.com/images/g/RKcAAOSweE5gsjDD/s-l1600.jpg",
                        Rating = "R",
                        Price = 5.99M
                    },

                    new Movie
                    {
                        Title = "Singles Ward 2",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        GenreId = 5,
                        ImageUrl = "https://i.ebayimg.com/images/g/RKcAAOSweE5gsjDD/s-l1600.jpg",
                        Rating = "R",
                        Price = 4.99M
                    },

                    new Movie
                    {
                        Title = "God's Army 2",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        GenreId = 6,
                        ImageUrl = "http://www.ldsfilm.com/pm/GodsArmyII.jpg",
                        Rating = "R",
                        Price = 6.99M
                    },

                    new Movie
                    {
                        Title = "On the Lord's Errand",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        GenreId = 4,
                        ImageUrl = "https://s3-us-west-2.amazonaws.com/ldsbookstore/products/On-the-Lord-s-Errand-DVD/on-the-lords-errand-dvd.jpg",
                        Rating = "R",
                        Price = 8.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}