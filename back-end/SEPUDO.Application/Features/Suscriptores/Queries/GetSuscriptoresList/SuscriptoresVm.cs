
namespace SEPUDO.Application.Features.Suscriptores.Queries.GetSuscriptoresList
{
    public class SuscriptoresVm
    {
        public long UsoId { get; set; }        
        public string? Codigo { get; set; }
        public int CodigoVerificacion { get; set; }
        public long Sistema { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public bool Alcantarillado { get; set; }
        public bool Aseo { get; set; }
        public int Atraso { get; set; }
        public string? Sector { get; set; }
        public string? Seccion { get; set; }
        public string? ManzanaDane { get; set; }
        public string? ManzanaIgac { get; set; }
        public string? ManzanaEstratifica { get; set; }
        public bool Bloqueo { get; set; }
    }
}
