using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_end.DTO
{
    public class ConsumoDTO
    {
        public long Id { get; set; }
        public long SuscriptorId { get; set; }        
        public long Consumo1 { get; set; }
        public long Consumo2 { get; set; }
        public long Consumo3 { get; set; }
        public long Consumo4 { get; set; }
        public long Consumo5 { get; set; }
        public long Consumo6 { get; set; }
        public long ConsumoActual { get; set; }
    }
}
