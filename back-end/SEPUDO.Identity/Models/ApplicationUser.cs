using Microsoft.AspNetCore.Identity;


namespace SEPUDO.Identity.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Nombre { get; set; }=string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public  long? IdEmpresa { get; set; }

    }
}
