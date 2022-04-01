
using SEPUDO.Domain.Entidades;

namespace SEPUDO.Application.Contracts.Persistence
{
    public interface  ISuscriptorRepository:IAsyncRepository<Suscriptor>
    {
        Task<Suscriptor> GetSuscriptorByNombre(string nombreSuscriptor);
        Task<IEnumerable<Suscriptor>> GetSuscriptorBNyUserName(string userName);

    }
}
