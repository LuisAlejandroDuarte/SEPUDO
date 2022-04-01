using AutoMapper;
using SEPUDO.Domain.Entidades;
using MediatR;
using Microsoft.Extensions.Logging;
using SEPUDO.Application.Contracts.Infrastructure;
using SEPUDO.Application.Contracts.Persistence;
using SEPUDO.Application.Models;

namespace SEPUDO.Application.Features.Usos.Commnads.CreateUso
{
    public class CreateUsoCommandHandler : IRequestHandler<CreateUsoCommand, long>
    {
        //private readonly IUsoRepository usoRepository;
        private readonly IUnitOfWork unitOfWork;
        private IMapper mapper;
        private readonly IEmailService emailService;
        private readonly ILogger<CreateUsoCommandHandler> logger;

        public CreateUsoCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IEmailService emailService, ILogger<CreateUsoCommandHandler> logger)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.emailService = emailService;
            this.logger = logger;
        }

        public async Task<long> Handle(CreateUsoCommand request, CancellationToken cancellationToken)
        {
            var usoEntity = mapper.Map<Uso>(request);
            //var newUso = await usoRepository.AddAsync(usoEntity);
            unitOfWork.UsoRepository.AddEntity(usoEntity);
            var result= await unitOfWork.Complete();
            if (result<=0)
            {
                throw new Exception($"No se pudo insertar el record uso");
            }
            logger.LogInformation($"Uso {usoEntity.Id} fue creado exitosamente");
          //  await SendEmail(newUso);
            return usoEntity.Id;
        }

        private async Task SendEmail(Uso uso)
        {
            var email = new Email
            {
                To = "ladm4@hotmail.com",
                Body = "Se crea correctamente",
                Subject = "Mensaje de alerta"
            };

            try
            {
                await emailService.SendEmail(email);
            }
            catch (Exception ex)
            {
                logger.LogError($"Errores enviando el email de {uso.Id}");
                throw;
            }
            
        }
    }
}
