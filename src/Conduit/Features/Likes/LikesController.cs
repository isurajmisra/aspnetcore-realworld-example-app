using System.Threading.Tasks;
using Conduit.Infrastructure.Security;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Conduit.Features.Likes
{
    [Route("articles")]
    public class LikesController : Controller
    {
        private readonly IMediator _mediator;

        public LikesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        public async Task<LikeEnvelope> Add(string slug, [FromBody] Add.Command command)
        {
            command.Slug = slug;
            return await _mediator.Send(command);
        }
    }
} 
