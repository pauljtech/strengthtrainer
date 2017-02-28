using StrengthTrainer.Data;
using StrengthTrainer.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace StrengthTrainer.Controllers
{
    public class SetsController : ApiController
    {
        private StrengthTrainerContext db = new StrengthTrainerContext();

        // GET api/Sets
        public IQueryable<Set> Get()
        {
            return db.Sets;
        }

        // GET: api/Sets/5
        [ResponseType(typeof(Set))]
        public async Task<IHttpActionResult> GetSet(int id)
        {
            Set set = await db.Sets.FindAsync(id);
            if (set == null)
            {
                return NotFound();
            }

            return Ok(set);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}