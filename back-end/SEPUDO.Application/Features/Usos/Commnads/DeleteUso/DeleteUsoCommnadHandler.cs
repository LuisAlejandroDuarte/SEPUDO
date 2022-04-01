using AutoMapper;
using SEPUDO.Domain.Entidades;
using MediatR;
using Microsoft.Extensions.Logging;
using SEPUDO.Application.Contracts.Persistence;
using SEPUDO.Application.Exceptions;

namespace SEPUDO.Application.Features.Usos.Commnads.DeleteUso
{
    public class DeleteUsoCommnadHandler : IRequestHandler<DeleteUsoCommnad>
    {
        //private readonly IUsoRepository usoRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly ILogger<DeleteUsoCommnad> logger;

        public DeleteUsoCommnadHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<DeleteUsoCommnad> logger)
        {
            //this.usoRepository = usoRepository;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.logger = logger;
        }



        public async Task<Unit> Handle(DeleteUsoCommnad request, CancellationToken cancellationToken)
        {
            var usoToDelete = await unitOfWork.UsoRepository.GetByIdAsync(request.Id);
            if (usoToDelete == null)
            {
                logger.LogError($"{request.Id} No existe en el sistema");
                throw new NotFoundException(nameof(Uso), request.Id);
            }
            //await usoRepository.DeleteAsync(usoToDelete);
            unitOfWork.UsoRepository.DeleteEntity(usoToDelete);
            await unitOfWork.Complete();
            logger.LogInformation($"{request.Id} fue eliminado con éxito");
            return Unit.Value;
        }
    }
}
