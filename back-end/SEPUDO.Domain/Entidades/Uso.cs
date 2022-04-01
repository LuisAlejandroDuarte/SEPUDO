using SEPUDO.Domain.Common;

namespace SEPUDO.Domain.Entidades
{
    public class Uso: BaseDomainModel
    {
        
        public int Codigo { get; set; }
        public int Estrato { get; set; }
        public string? Descripcion { get; set; }    
        public ICollection<Suscriptor>? Suscriptores { get; set; }
    }
}
