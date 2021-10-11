using System.Collections.Generic;
using Application.Posts;
using  System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

using Persistence;

namespace API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]

  public class PostsController : ControllerBase
  {
       private readonly IMediator mediator;

       public PostsController(IMediator mediator) => this.mediator = mediator;

       public async Task<ActionResult<List<Post>>> List()
       {
           return await this.mediator.Send(new List.Query());
       }
  }

}