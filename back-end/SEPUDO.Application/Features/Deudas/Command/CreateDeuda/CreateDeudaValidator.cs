using FluentValidation;

namespace SEPUDO.Application.Features.Deudas.Command.CreateDeuda
{
    public  class CreateDeudaValidator:AbstractValidator<CreateDeudaCommand>
    {
        public CreateDeudaValidator()
        {
            RuleFor(p => p.Nombre)
                .NotEmpty().WithMessage("{Nombre} no puede ser en blanco")
                .NotNull()
                .MaximumLength(200).WithMessage("{Nombre} no puede exceder los 200 caracteres");
        }
    }
}
