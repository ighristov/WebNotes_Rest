using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using oaWebNotes;

namespace WebNotes_Rest.Controllers
{
    public class CategoriesController : ApiController
    {
        private static List<Category> categories = Note.Categories;
        // GET api/categories
        public IEnumerable<Category> Get()
        {
            return categories;
        }

        // GET api/categories/5
        public Category Get(int id)
        {
            return categories.Single(c=>c.FID == id);
        }

        // POST api/categories
        public void Post([FromBody]string value)
        {
        }

        // PUT api/categories/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/categories/5
        public void Delete(int id)
        {
        }
    }
}
