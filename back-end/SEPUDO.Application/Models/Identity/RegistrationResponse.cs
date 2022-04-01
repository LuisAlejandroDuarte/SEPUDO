
namespace SEPUDO.Application.Models.Identity
{
    public class RegistrationResponse
    {
        public string UserId { get; set; }=string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;                
        public string Token { get; set; } = string.Empty;

    }
}
