

using MediatR;

namespace SEPUDO.Application.Features.Usos.Commnads.DeleteUso
{
    public class DeleteUsoCommnad:IRequest
    {
        public long Id { get; set; }
    }
}
