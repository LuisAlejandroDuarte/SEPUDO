using MediatR;

namespace SEPUDO.Application.Features.Suscriptores.Queries.GetSuscriptoresList
{
    public class GetSuscriptoresListQuery:IRequest<List<SuscriptoresVm>>
    {
        public string UserName { get; set; } =String.Empty;
        public GetSuscriptoresListQuery(string userName)
        {
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));
        }
    }
}
