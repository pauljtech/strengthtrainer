using StrengthTrainer.Data;
using StrengthTrainer.Data.Entities;
using StrengthTrainer.Logic;
using StrengthTrainer.Models;
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
        private SetProvider provider = new SetProvider();

        // GET: api/Sets/5
        [ResponseType(typeof(SetModel))]
        public async Task<IHttpActionResult> GetSet(int id)
        {
            SetModel set = await provider.GetSet(id);

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


    }
}