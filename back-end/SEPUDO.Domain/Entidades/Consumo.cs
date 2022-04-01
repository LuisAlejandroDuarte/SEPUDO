

using SEPUDO.Domain.Common;

namespace SEPUDO.Domain.Entidades
{
    public class Consumo:BaseDomainModel
    {        
        public long SuscriptorId { get; set; }
        public Suscriptor? Suscriptor { get; set; }
        public long Consumo1 { get; set; }
        public long Consumo2 { get; set; }
        public long Consumo3 { get; set; }
        public long Consumo4 { get; set; }
        public long Consumo5 { get; set; }
        public long Consumo6 { get; set; }
        public long ConsumoActual { get; set; }


    }
}
