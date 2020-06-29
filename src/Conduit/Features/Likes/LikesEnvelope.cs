using Conduit.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conduit.Features.Likes
{
    public class LikesEnvelope
    {
        public LikesEnvelope(List<Like> likes)
        {
            Likes = likes;
        }

        public List<Like> Likes { get; }
    }
}
