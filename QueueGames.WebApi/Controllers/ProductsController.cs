using QueueGames.Data;
using QueueGames.Data.Context;
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
        private ProductRepository productRepositorie = new ProductRepository();

        // GET api/<controller>
        public string Get()
        {
            System.Threading.Thread.Sleep(2000);
            return Newtonsoft.Json.JsonConvert.SerializeObject(productRepositorie.GetAll());
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(productRepositorie.Get(id));
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]Products product)
        {
            try
            {
                productRepositorie.Insert(product);
                return Ok(product.ProductID);
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }   
        }

        [HttpPut]
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