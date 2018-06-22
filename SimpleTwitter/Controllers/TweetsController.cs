using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleTwitter.Data;
using SimpleTwitter.Models;

namespace SimpleTwitter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TweetsController : ControllerBase
    {
        private readonly ApplicationDbContext db;
        public TweetsController(ApplicationDbContext db)
        {
            this.db = db;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Tweet> Get()
        {
            return db.Tweets;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Tweet Get(int id)
        {
            return db.Tweets.FirstOrDefault(t=>t.Id == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Tweet tweet)
        {
            tweet.Date = DateTime.Now;
            db.Tweets.Add(tweet);
            db.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var tweet = db.Tweets.FirstOrDefault(t => t.Id == id);
            db.Tweets.Remove(tweet);
            db.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Tweet tweet)
        {
            var tw = db.Tweets.FirstOrDefault(t => t.Id == id);
            tw.Text = tweet.Text;
            tw.Date = DateTime.Now;
            db.SaveChanges();
        }
    }
}
