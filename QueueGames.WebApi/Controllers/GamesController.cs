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
    [EnableCors(origins: "http://localhost:10069", headers: "*", methods: "*" )]
    public class GamesController : ApiController
    {
        private GamesRepository gamesRepositorie = new GamesRepository();

        // GET api/games
        public string Get()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(gamesRepositorie.GetAll());
        }

        // GET api/games/5
        public string Get(int id)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(gamesRepositorie.Get(id));
        }

        // POST api/games
        public IHttpActionResult Post([FromBody]Games game)
        {
            System.Threading.Thread.Sleep(1500);

            if ((DateTime.Now.Millisecond % 2) > 0)
                return Ok();
            else
                return InternalServerError();
        }

        // PUT api/games/5
        public void Put(int id, [FromBody]Games game)
        {
        }

        // DELETE api/games/5
        public void Delete(int id)
        {
        }
    }
}
