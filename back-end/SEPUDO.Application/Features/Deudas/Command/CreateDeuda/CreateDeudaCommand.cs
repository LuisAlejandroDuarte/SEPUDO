using MediatR;

namespace SEPUDO.Application.Features.Deudas.Command.CreateDeuda
{
    public class CreateDeudaCommand:IRequest<long>
    {
        public string Nombre { get; set; } =string.Empty;
    }
}
