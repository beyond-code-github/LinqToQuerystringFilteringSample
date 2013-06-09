namespace LinqToQuerystringFilteringSample.Controllers
{
    using System.Web.Http;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using LinqToQuerystring.WebApi;

    using LinqToQuerystringFilteringSample.Models;

    public class ValuesController : ApiController
    {
        // GET api/values
        [LinqToQueryable]
        public IQueryable<Movie> Get()
        {
            return
                new List<Movie>
                    {
                        new Movie
                            {
                                Title = "Matrix (The)", ReleaseDate = new DateTime(1999, 3, 31),
                                MetaScore = 73, Director = "Andy Wachowski\\Lana Wachowski",
                                Recommended = true
                            },
                        new Movie
                            {
                                Title = "Avatar", ReleaseDate = new DateTime(2009, 12, 17),
                                MetaScore = 83, Director = "James Cameron",
                                Recommended = false
                            },
                        new Movie
                            {
                                Title = "Spaceballs", ReleaseDate = new DateTime(1987, 6, 24),
                                Director = "Mel Brooks", MetaScore = 46,
                                Recommended = true
                            },
                        new Movie
                            {
                                Title = "Return of the Jedi", ReleaseDate = new DateTime(1983, 6, 2),
                                MetaScore = 52, Director = "Richard Marquand",
                                Recommended = true
                            },
                        new Movie
                            {
                                Title = "Fellowship of the ring (The)", ReleaseDate = new DateTime(2001, 12, 10),
                                MetaScore = 92, Director = "Peter Jackson",
                                Recommended = true
                            }
                    }.AsQueryable();
        }
    }
}