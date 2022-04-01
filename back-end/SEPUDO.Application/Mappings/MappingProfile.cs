using AutoMapper;
using SEPUDO.Application.Features.Deudas.Command.CreateDeuda;
using SEPUDO.Application.Features.Suscriptores.Queries.GetSuscriptoresList;
using SEPUDO.Application.Features.Usos.Commnads.CreateUso;
using SEPUDO.Application.Features.Usos.Commnads.UpdateUso;
using SEPUDO.Domain.Entidades;

namespace SEPUDO.Application.Mappings
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Suscriptor, SuscriptoresVm>();
            CreateMap<CreateUsoCommand, Uso>();
            CreateMap<UpdateUsoCommand, Uso>();
            CreateMap<CreateDeudaCommand, Deuda>();            
        }
    }
}
