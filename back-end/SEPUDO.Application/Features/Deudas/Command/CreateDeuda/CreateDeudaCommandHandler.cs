using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using SEPUDO.Application.Contracts.Persistence;
using SEPUDO.Domain.Entidades;

namespace SEPUDO.Application.Features.Deudas.Command.CreateDeuda
{
    public class CreateDeudaCommandHandler : IRequestHandler<CreateDeudaCommand, long>
    {
        private readonly ILogger<CreateDeudaCommandHandler> logger;
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public CreateDeudaCommandHandler(ILogger<CreateDeudaCommandHandler> logger, IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.logger = logger;
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }

        public async Task<long> Handle(CreateDeudaCommand request, CancellationToken cancellationToken)
        {
            var deudaEntity = mapper.Map<Deuda>(request);
            unitOfWork.Repository<Deuda>().AddEntity(deudaEntity);
            var result= await unitOfWork.Complete();

            if (result<=0)
            {
                logger.LogError("No se insertó el record de la deuda");
                throw new Exception("No se pudo insertar el record de deuda");
            }

            return deudaEntity.Id;

        }
    }
}
