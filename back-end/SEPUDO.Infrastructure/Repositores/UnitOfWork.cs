using SEPUDO.Application.Contracts.Persistence;
using SEPUDO.Domain.Common;
using SEPUDO.Infrastructure.Persistence;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPUDO.Infrastructure.Repositores
{
    public class UnitOfWork : IUnitOfWork
    {
        private Hashtable respositories;
        private readonly SepudoDbContext context;
        private  IUsoRepository usoRepository;
        private  ISuscriptorRepository suscriptorRepository;

        public ISuscriptorRepository SuscriptorRepository => suscriptorRepository ??= new SuscriptorRepository(context);
        public IUsoRepository UsoRepository => usoRepository ??= new UsoRepository(context);
        public UnitOfWork(SepudoDbContext context)
        {
            this.context = context;
        }

        public async Task<int> Complete()
        {
            return await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IAsyncRepository<TEntity> Repository<TEntity>() where TEntity : BaseDomainModel
        {
            if(respositories==null)
            {
                respositories = new Hashtable();

            }
            var type = typeof(TEntity).Name;
            if(!respositories.ContainsKey(type))
            {
                var repositoryType = typeof(RepositoryBase<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)),context);
                respositories.Add(type, repositoryInstance);

            }

            return (IAsyncRepository<TEntity>)respositories[type];
        }
    }
}
