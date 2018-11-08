using SvinefarmGr1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SvinefarmGr1.Controllers.API
{
    public class BarnController : ApiController
    {
        // GET: api/Barn
        [HttpGet]
        public IHttpActionResult Get()
        {
            using (var context = new ApplicationDbContext())
            {
                var barns = context.Barns.ToList();
                return Ok(barns);
            }
        }

        // GET: api/Barn/5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                var barn = context.Barns.SingleOrDefault(x => x.BarnId == id);
                return Ok(barn);
            }
        }

        // POST: api/Barn
        public IHttpActionResult Post([FromBody]string value)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Barns.Add(new Models.FarmManager.Barn(value));
                return Ok();
            }
        }

        // PUT: api/Barn/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Barn/5
        public void Delete(int id)
        {
        }
    }
}
