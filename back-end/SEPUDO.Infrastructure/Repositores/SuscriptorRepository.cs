using SEPUDO.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using SEPUDO.Application.Contracts.Persistence;
using SEPUDO.Infrastructure.Persistence;

namespace SEPUDO.Infrastructure.Repositores
{
    public class SuscriptorRepository : RepositoryBase<Suscriptor>, ISuscriptorRepository
    {
        
        public SuscriptorRepository(SepudoDbContext context):base(context)
        {
           
        }
        public async Task<IEnumerable<Suscriptor>> GetSuscriptorBNyUserName(string userName)
        {
           return await context.Suscriptores!.Where(s=>s.CreateBy==userName).ToListAsync();
        }

        public async Task<Suscriptor> GetSuscriptorByNombre(string nombreSuscriptor)
        {
          var suscriptor =await  context.Suscriptores!.Where(s => s.Nombre == nombreSuscriptor).FirstOrDefaultAsync();
          return suscriptor;
        }
    }
}
