using System;
using Conduit.Domain;

namespace Conduit.Features.Likes
{
    public class LikeEnvelope
    {
        public LikeEnvelope(Like like)
        {
            Like = like;
        }

        public Like Like { get; }
    }
}
