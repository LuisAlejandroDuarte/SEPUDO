using FluentValidation;


namespace SEPUDO.Application.Features.Usos.Commnads.CreateUso
{
    public class CreateUsoCommandValidator : AbstractValidator<CreateUsoCommand>
    {
        public CreateUsoCommandValidator()
        {
            RuleFor(p => p.Descripcion)
                .NotEmpty().WithMessage("{Descripcion} no puede ser en blanco")
                .NotNull()
                .MaximumLength(200).WithMessage("{Descripcion} no puede exceder los 50 caracteres");
        }
    }
}
