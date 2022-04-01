using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace back_end.DTO
{
    public class UsoDTO
    {
        public long Id { get; set; }
        public int Codigo { get; set; }
        public int Estrato { get; set; }
        public string Descripcion { get; set; }
    }
}
