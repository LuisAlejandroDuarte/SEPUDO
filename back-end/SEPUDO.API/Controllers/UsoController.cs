using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SEPUDO.Application.Features.Usos.Commnads.CreateUso;
using SEPUDO.Application.Features.Usos.Commnads.DeleteUso;
using SEPUDO.Application.Features.Usos.Commnads.UpdateUso;
using System.Net;

namespace SEPUDO.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UsoController: ControllerBase
    {
        private readonly IMediator mediator;

        public UsoController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost(Name ="CreateUso")]
        [Authorize(Roles= "Administrador")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<long>> CreateUso([FromBody] CreateUsoCommand command)
        {
            return await mediator.Send(command);
        }

        [HttpPut(Name ="UpdateUso")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> UpdateUso([FromBody] UpdateUsoCommand command)
        {
            await mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{Id}",Name ="DeleteUso")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> DeleteUso(long Id)
        {

            var command = new DeleteUsoCommnad
            {
                Id = Id
            };

            await mediator.Send(command);

            return NoContent();
        }

    }
}
