using MediatR;

namespace SEPUDO.Application.Features.Usos.Commnads.CreateUso
{
    public class CreateUsoCommand:IRequest<long>
    {
        public int Codigo { get; set; }
        public int Estrato { get; set; }
        public string Descripcion { get; set; } = string.Empty;
    }
}
