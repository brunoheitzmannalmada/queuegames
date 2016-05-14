using QueueGames.Data;
using QueueGames.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace QueueGames.WebApi.Controllers
{
    [EnableCors(origins: "http://localhost:10069", headers: "*", methods: "*")]
    public class ProductsController : ApiController
    {
        private ProductRepositorie productRepositorie = new ProductRepositorie();

        // GET api/<controller>
        public string Get()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(productRepositorie.GetAll());
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(productRepositorie.Get(id));
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