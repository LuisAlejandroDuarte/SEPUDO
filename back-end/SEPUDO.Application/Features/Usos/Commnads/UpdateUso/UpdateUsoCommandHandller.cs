using AutoMapper;
using SEPUDO.Domain.Entidades;
using MediatR;
using Microsoft.Extensions.Logging;
using SEPUDO.Application.Contracts.Persistence;
using SEPUDO.Application.Exceptions;


namespace SEPUDO.Application.Features.Usos.Commnads.UpdateUso
{
    public class UpdateUsoCommandHandller : IRequestHandler<UpdateUsoCommand>
    {
        //private readonly IUsoRepository usoRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly ILogger<UpdateUsoCommandHandller> logger;

        public UpdateUsoCommandHandller(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateUsoCommandHandller> logger)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.logger = logger;
        }

        public async Task<Unit> Handle(UpdateUsoCommand request, CancellationToken cancellationToken)
        {
            //var usoToUpdate=  await  usoRepository.GetByIdAsync(request.Id);
            var usoToUpdate = await unitOfWork.UsoRepository.GetByIdAsync(request.Id);

            if (usoToUpdate == null)
            {
                logger.LogError($"No se encontró el uso Id {request.Id}");
                throw new NotFoundException(nameof(Uso), request.Id);
            }

            mapper.Map(request, usoToUpdate,typeof(UpdateUsoCommand),typeof(Uso));

            //await usoToUpdate.UpdateAsync(usoToUpdate);
            unitOfWork.UsoRepository.UpdateEntity(usoToUpdate);
            await unitOfWork.Complete();

            logger.LogInformation($"La operación fue exitosa actualizando el uso {request.Id}");

            return Unit.Value;
        }
    }
}
