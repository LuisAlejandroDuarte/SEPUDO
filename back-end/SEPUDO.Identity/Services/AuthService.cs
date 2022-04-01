using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SEPUDO.Application.Constants;
using SEPUDO.Application.Contracts.Identity;
using SEPUDO.Application.Models.Identity;
using SEPUDO.Identity.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SEPUDO.Identity.Services
{
    public class AuthService : IAuthService
    {
        

        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
          
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly JwtSettings jwtSettings;

        public AuthService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager, IOptions<JwtSettings> jwtSettings)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.jwtSettings = jwtSettings.Value;
            this.roleManager = roleManager;
        }

        public List<RoleResponse> GetRoles()
        {
            var roles = roleManager.Roles;
            List<RoleResponse> lista = new List<RoleResponse>();
            foreach(var item in roles)
            {
                lista.Add(new RoleResponse()
                {
                    Id = item.Id,
                    Name=item.Name,
                    NormalizedName=item.NormalizedName
                });
            }

            return lista;
        }

        public async Task<AuthResponse> Login(AuthRequest request)
        {
            //var user =await userManager.FindByEmailAsync(request.Email);
            var user =  userManager.Users.First(x => x.IdEmpresa == request.IdEmpresa && x.Email == request.Email);

            if (user==null)
            {
                throw new Exception($"El usuario con email {request.Email} no existe");
            }

            var resultado = await signInManager.PasswordSignInAsync(user.UserName, request.Password, false, lockoutOnFailure: false);
            if (!resultado.Succeeded)
            {
                throw new Exception($"La clave es incorrecta");
            }

            var token = await GeneratorToken(user);
            var authResponse = new AuthResponse
            {
                Id = user.Id,
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Email = user.Email,
                UserName = user.UserName,
                

            };

            return authResponse;
        }



        

        public async Task<RegistrationResponse> Register(RegistrationRequest request)
        {
            var existenUSer = await userManager.FindByNameAsync(request.UserName);
            if (existenUSer!=null)
            {
                throw new Exception($"El userName ya existe en otra cuenta");
            }

            var existingEmail = await userManager.FindByEmailAsync(request.Email);
            if (existingEmail!=null)
            {
                throw new Exception($"El email ya existe en otra cuenta");
            }

            var user = new ApplicationUser
            {
                Email = request.Email,
                Nombre = request.Nombre,
                Apellidos = request.Apellidos,
                UserName = request.UserName,
                EmailConfirmed = true
            };

            var result = await userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, "Operator");
                var token = await GeneratorToken(user);

                return new RegistrationResponse
                {
                    Email = request.Email,
                    Token = new JwtSecurityTokenHandler().WriteToken(token),
                    UserId =user.Id,
                    UserName=user.UserName
                };
            }

            throw new Exception($"{result.Errors}");
        }

        public async  Task<RoleResponse> RegisterRole(RoleRequest request)
        {
            Guid uid = Guid.NewGuid();

            var identityRole = new IdentityRole
            {
                Id=uid.ToString(),
                Name = request.Name,
                NormalizedName = request.NormalizedName
            };

            var result = await roleManager.CreateAsync(identityRole);

            if (result.Succeeded)
            {
                return new RoleResponse
                {
                    Id = uid.ToString(),
                    Name = request.Name,
                    NormalizedName = request.NormalizedName
                };
            }

            throw new Exception($"{result.Errors}");

        }

        public async Task<AuthResponse> ReNewToken(string token)
        {
            var handler = new JwtSecurityTokenHandler();
           
           ClaimsPrincipal data= handler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateAudience = false,
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Key)),
                ValidateLifetime = false
            }, out SecurityToken validatedToken);

           var id= data.Claims.First(c => c.Type == CustomClaimTypes.Uid)?.Value;

           var user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                throw new Exception($"El token no es válido ");
            }


            var newToken = await GeneratorToken(user);

            return  new AuthResponse
            {
                Id = user.Id,
                Token = new JwtSecurityTokenHandler().WriteToken(newToken),
                Email = user.Email,
                UserName = user.UserName,
                Nombre=user.Nombre,
                Apellidos=user.Apellidos,
                Direccion=user.Direccion,
                Telefono=user.Telefono,
                Roles=  await userManager.GetRolesAsync(user)
            };

        }

        public async Task<RegistrationResponse> UpdateUser(RegistrationRequest request)
        {
            var user = await userManager.FindByIdAsync(request.Id);

            if (user==null)
            {
                throw new Exception($"No existe el usuario");
            }
            
            if (user.Email != request.Email)
            {
                var existenEmail = userManager.Users.First(x => x.IdEmpresa == request.IdEmpresa && x.Email == request.Email);

                if (existenEmail != null)
                {
                    throw new Exception($"El correo ya lo tiene otro usuario");
                }
            }


            user.Email = request.Email;
            user.Nombre = request.Nombre;
            user.Apellidos = request.Apellidos;
            user.UserName = request.UserName;
            user.Direccion = request.Direccion;
            user.Telefono = request.Telefono;
                
            

            var result = await userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return new RegistrationResponse
                {
                    Email = request.Email,
                    Nombre = request.Nombre,
                    Apellidos = request.Apellidos,
                    UserName = request.UserName,
                    Direccion = request.Direccion,
                    Telefono = request.Telefono,
                };
            }
            throw new Exception($"{result.Errors}");
        }

        private async Task<JwtSecurityToken> GeneratorToken(ApplicationUser user)
        {
            var userClaims = await userManager.GetClaimsAsync(user);
            var roles = await userManager.GetRolesAsync(user);

            var roleClaims = new List<Claim>();

            foreach (var role in roles)
            {
                roleClaims.Add(new Claim(ClaimTypes.Role, role));
            }

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,user.UserName),
                new Claim(JwtRegisteredClaimNames.Email,user.Email),
                new Claim(CustomClaimTypes.Uid,user.Id),
            }.Union(userClaims).Union(roleClaims);

            var symetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Key));

            var signingCredetials = new SigningCredentials(symetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(

                issuer: jwtSettings.Issuer,
                audience: jwtSettings.Audience,
                claims:claims,
                expires:DateTime.UtcNow.AddMinutes(jwtSettings.DurationInMinutes),
                signingCredentials:signingCredetials
           );                

            return jwtSecurityToken; 
        }
         
    }
}
