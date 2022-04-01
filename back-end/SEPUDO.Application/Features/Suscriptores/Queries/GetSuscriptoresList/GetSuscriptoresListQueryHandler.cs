using AutoMapper;
using MediatR;
using SEPUDO.Application.Contracts.Persistence;

namespace SEPUDO.Application.Features.Suscriptores.Queries.GetSuscriptoresList
{
    public class GetSuscriptoresListQueryHandler : IRequestHandler<GetSuscriptoresListQuery, List<SuscriptoresVm>>
    {
        //private readonly ISuscriptorRepository suscriptorRepositorio;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetSuscriptoresListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            //this.suscriptorRepositorio = suscriptorRepositorio;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<List<SuscriptoresVm>> Handle(GetSuscriptoresListQuery request, CancellationToken cancellationToken)
        {
            //var suscriptorList = await suscriptorRepositorio.GetSuscriptorBNyUserName(request.UserName);
            var suscriptorList = await unitOfWork.SuscriptorRepository.GetSuscriptorBNyUserName(request.UserName);

            return mapper.Map<List<SuscriptoresVm>>(suscriptorList);
        }
    }
}
