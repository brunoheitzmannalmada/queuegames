using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QueueGames.WebApi.Controllers
{
    public class BuyController : ApiController
    {
        // GET api/buy
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/buy/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/buy
        public IHttpActionResult Post([FromBody]string value)
        {
            System.Threading.Thread.Sleep(1500);

            if ((DateTime.Now.Millisecond % 2) > 0)
                return Ok();
            else
                return InternalServerError();
        }

        // PUT api/buy/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/buy/5
        public void Delete(int id)
        {
        }
    }
}
