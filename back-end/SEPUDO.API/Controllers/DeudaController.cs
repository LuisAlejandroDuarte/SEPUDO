using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SEPUDO.Application.Features.Deudas.Command.CreateDeuda;
using System.Net;

namespace SEPUDO.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class DeudaController:ControllerBase
    {
        private IMediator mediator;

        public DeudaController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost(Name ="CreateDeuda")]
       // [Authorize(Roles="Administrador")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<long>> CreateDeuda([FromBody] CreateDeudaCommand command)
        {
            return await mediator.Send(command);
        }
    }
}
