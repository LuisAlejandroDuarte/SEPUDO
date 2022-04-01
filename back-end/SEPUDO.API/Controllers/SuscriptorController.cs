using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SEPUDO.Application.Features.Suscriptores.Queries.GetSuscriptoresList;
using System.Net;

namespace SEPUDO.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SuscriptorController:ControllerBase
    {
        private readonly IMediator mediator;
        public SuscriptorController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpGet("{username}",Name ="GetSuscriptor")]
        [Authorize]
        [ProducesResponseType(typeof(IEnumerable<SuscriptoresVm>),(int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<SuscriptoresVm>>> GetsuscriptoresByUserName(string username)
        {
            var query = new GetSuscriptoresListQuery(username);
            var suscriptores = await  mediator.Send(query);

            return Ok(suscriptores);
        }

    }
}
