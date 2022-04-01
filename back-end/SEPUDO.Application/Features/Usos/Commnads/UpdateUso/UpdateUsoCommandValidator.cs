using FluentValidation;


namespace SEPUDO.Application.Features.Usos.Commnads.UpdateUso
{
    public class UpdateUsoCommandValidator : AbstractValidator<UpdateUsoCommand>
    {
        public UpdateUsoCommandValidator()
        {
            RuleFor(p => p.Descripcion)
                .NotNull().WithMessage("{Descripcion} no permite nulos");
        }
    }
}
