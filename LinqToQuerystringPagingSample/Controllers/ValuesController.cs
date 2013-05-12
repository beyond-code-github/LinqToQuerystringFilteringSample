using System.Web.Http;

namespace LinqToQuerystringPagingSample.Controllers
{
    using System.Linq;

    using LinqToQuerystring.WebApi;

    public class ValuesController : ApiController
    {
        // GET api/values
        [LinqToQueryable]
        public IQueryable<string> Get()
        {
            return new string[] { "Optimus prime", "Megatron", "Lion-o", "Snarf", "He-man", "Skeletor" }.AsQueryable();
        }
    }
}