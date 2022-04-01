using back_end.Entidades;
using SEPUDO.Application.Contracts.Persistence;
using SEPUDO.Domain.Entidades;
using SEPUDO.Infrastructure.Persistence;


namespace SEPUDO.Infrastructure.Repositores
{
    public  class UsoRepository:RepositoryBase<Uso>,IUsoRepository
    {
        public UsoRepository(SepudoDbContext context):base(context)
        {

        }
    }
}
