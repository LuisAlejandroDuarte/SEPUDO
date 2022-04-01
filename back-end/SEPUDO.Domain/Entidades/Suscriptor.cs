using SEPUDO.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEPUDO.Domain.Entidades
{
    public class Suscriptor: BaseDomainModel
    {        
        public long UsoId { get; set; }
        public virtual Uso? Uso { get; set; }
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
        public bool? Bloqueo { get; set; }
        public long? IdEmprsa { get; set; }

    }
}
