using Microsoft.AspNetCore.Mvc;
using SEPUDO.Application.Contracts.Identity;
using SEPUDO.Application.Models.Identity;

namespace SEPUDO.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAuthService authService;
        

        public AccountController(IAuthService authService)
        {
            this.authService = authService;          
        }

        [HttpPost("Login")]
        public async Task<ActionResult<AuthResponse>> Login ([FromBody] AuthRequest request)
        {
            return Ok(await authService.Login(request));
        }

        [HttpGet("ReNewToken")]
        public async Task<ActionResult<AuthResponse>> ReNewToken([FromHeader(Name ="x-token")] string token)
        {          
            return Ok(await authService.ReNewToken(token));                       
        }



        [HttpPost("Register")]
        public async Task<ActionResult<RegistrationResponse>> Register([FromBody] RegistrationRequest request)
        {
            return Ok(await authService.Register(request));
        }



        [HttpPut("UpdateUser")]
        public async Task<ActionResult<RegistrationResponse>> UpdateUser([FromBody] RegistrationRequest request)
        {
            return Ok(await authService.UpdateUser(request));
        }

        [HttpPost("Role")]
        public async Task<ActionResult<RoleResponse>> Register([FromBody] RoleRequest request)
        {
            return Ok(await authService.RegisterRole(request));
        }

        [HttpGet("Role")]
        public List<RoleResponse> GetRoles()
        {
            return authService.GetRoles();
        }

    }
}
