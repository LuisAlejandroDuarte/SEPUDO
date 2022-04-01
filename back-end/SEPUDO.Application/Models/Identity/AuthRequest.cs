

namespace SEPUDO.Application.Models.Identity
{
    public class AuthRequest
    {
        public string Email { get; set; }  =string.Empty;
        public string Password { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public long IdEmpresa { get; set; }
        public List<string>? Roles { get; set; }
        

        
    }
}
