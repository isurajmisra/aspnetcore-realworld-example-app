using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conduit.Domain
{
    public class Like
    {
        [JsonProperty("id")]
        public int LikeId { get; set; }

        public Person Author { get; set; }

        [JsonIgnore]
        public int AuthorId { get; set; }

        [JsonIgnore]
        public Article Article { get; set; }

        [JsonIgnore]
        public int ArticleId { get; set; }
    }
}
