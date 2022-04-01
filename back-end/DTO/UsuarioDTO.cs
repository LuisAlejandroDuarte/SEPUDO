using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_end.DTO
{
    public enum TipoUsuario
    {
        Administrativo, Operario
    }

    public class UsuarioDTO
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
    }
}
