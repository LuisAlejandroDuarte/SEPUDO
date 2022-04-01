using MediatR;


namespace SEPUDO.Application.Features.Usos.Commnads.UpdateUso
{
    public class UpdateUsoCommand:IRequest
    {
        public long Id { get; set; }

        public int Codigo { get; set; }
        public int Estrato { get; set; }
        public string Descripcion { get; set; } = string.Empty;
    }
}
