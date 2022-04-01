using AutoMapper;
using back_end.DTO;
using back_end.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_end.Controllers
{
    [Route("api/suscriptor")]
    [ApiController]
    public class SuscriptorController : ControllerBase
    {
        private readonly AplicationDbContext context;
        private readonly IMapper mapper;

        public SuscriptorController(AplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] SuscriptorDTO suscriptorDTO)
        {
            var suscriptor = mapper.Map<Suscriptor>(suscriptorDTO);
            context.Add(suscriptor);
            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}
