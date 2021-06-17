/*
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

namespace TodoApi.Controllers
{

    //@CrossOrigin(origins = "http://www.example.com:80")
    //[EnableCors]
    [Route("api/[controller]")]
    public class CatController : Controller
    {

        //api/cat
        [HttpGet]
        public IEnumerable<Cat> GetAll()
        {
            var list = new List<Cat>();
            list.Add(new Cat() { Name = "Lilly" });
            list.Add(new Cat() { Name = "Lucy" });
            return list;
        }

        //api/cat/{name}
        [HttpGet("{name}")]
        public Cat Get(string name)
        {
            return new Cat() { Name = name };
        }

        //api/cat
        [HttpPost]
        public Cat Insert([FromBody]Cat cat)
        {
            // write the new cat to database
            return cat;
        }

        //api/cat/{name}
        [HttpPut("{name}")]
        public Cat Update(string name, [FromBody]Cat cat)
        {
            cat.Name = name;
            // write the updated cat to database
            return cat;
        }

        //api/cat/{name}
        [HttpDelete("{name}")]
        public void Delete(string name)
        {
            // delete the cat from the database

        }
    }
}
*/