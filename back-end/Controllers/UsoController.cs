using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back_end.DTO;
using back_end.Entidades;
using Microsoft.AspNetCore.Mvc;
namespace back_end.Controllers
{
    [Route("api/uso")]
    [ApiController]
    public class UsoController: ControllerBase
    {
        private readonly AplicationDbContext context;
        private readonly IMapper mapper;

        public UsoController(AplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost]        
        public async Task<ActionResult> Post([FromBody] UsoDTO usoDTO)
        {
            var uso = mapper.Map<Uso>(usoDTO);
            context.Add(uso);
            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}
