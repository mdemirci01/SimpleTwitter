using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleTwitter.Models
{
    public class Db
    {
        public IList<Tweet> Tweets { get; set; }
        public Db()
        {
            Tweets = new List<Tweet>();
            Tweets.Add(new Tweet() { Id = 1, Text = "MErhaba", Date = DateTime.Now });
            Tweets.Add(new Tweet() { Id = 2, Text = "Selam!", Date = DateTime.Now });
        }
    }

}
