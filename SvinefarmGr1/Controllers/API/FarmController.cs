using SvinefarmGr1.Models;
using SvinefarmGr1.Models.FarmManager;
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
                if (farms.Count() == 0)
                {
                    return NotFound(); // If no farms - 404 
                }
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
                if (farm == null)
                {
                    return NotFound();
                }
                return Ok(farm);
            }

        }

        // POST: api/Farm
        [HttpPost]
        public IHttpActionResult Post([FromBody]string value)
        {
            using (var context = new ApplicationDbContext())
            {
                var farm = new Farm(value);

                // Save to context
                context.Farms.Add(farm);
                // Save farm to DB
                context.SaveChanges();

                return Ok(); // Return object? --> + page
            }
        }

        // PUT: api/Farm/5
        [HttpPut]
        public IHttpActionResult Put(int id, Farm farm)
        {
            using (var context = new ApplicationDbContext())
            {
                var ContFarm = context.Farms.SingleOrDefault(f => f.FarmId == id);
                if (ContFarm == null)
                {
                    return NotFound();
                }

                // Change the values given
                ContFarm.FarmName = farm.FarmName;
                ContFarm.Barns = farm.Barns;

                // Save to db

                return Ok();
            }
        }

        // DELETE: api/Farm/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                var farm = context.Farms.SingleOrDefault(f => f.FarmId == id);
                if (farm == null)
                {
                    return NotFound();
                }

                context.Farms.Remove(farm);

                // Save to db

                return Ok();
            }
        }
    }
}
