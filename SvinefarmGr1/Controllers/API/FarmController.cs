using SvinefarmGr1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SvinefarmGr1.Controllers.API
{
    public class FarmController : ApiController
    {
        // GET: api/Farm
        [HttpGet]
        public IHttpActionResult Get()
        {
            using (var context = new ApplicationDbContext())
            {
                var farms = context.Farms.ToList();
                return Ok(farms);
            }

        }

        // GET: api/Farm/5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                var farm = context.Farms.SingleOrDefault(x => x.FarmId == id);
                return Ok(farm);
            }

        }

        // POST: api/Farm
        public IHttpActionResult Post([FromBody]string value)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Farms.Add(new Models.FarmManager.Farm(value));
                return Ok();
            }
        }

        // PUT: api/Farm/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Farm/5
        public void Delete(int id)
        {
        }
    }
}
