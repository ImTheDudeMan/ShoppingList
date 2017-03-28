using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingList.Ef;

namespace ShoppingList.Api.Controllers
{
    [Route("api/[controller]")]
    public class CategoriesController : Controller
    {
        private CategoryContext context;

        public CategoriesController(CategoryContext context)
        {
            this.context = context;
        }

        // GET api/values
        [HttpGet]
        public List<Category> Get()
        {
            return context.Categories.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
