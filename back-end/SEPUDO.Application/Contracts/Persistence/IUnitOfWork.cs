using SEPUDO.Domain.Common;

namespace SEPUDO.Application.Contracts.Persistence
{
    public interface  IUnitOfWork:IDisposable
    {
        ISuscriptorRepository SuscriptorRepository { get; }
        IUsoRepository UsoRepository { get; }
        IAsyncRepository<TEntity> Repository<TEntity>() where TEntity : BaseDomainModel;

        Task<int> Complete();
    }
}
