using FluentValidation;


namespace CleanArchitecture.Application.Features.Autores.Commands.CreateAutor
{
    public class CreateAutorCommandValidator : AbstractValidator<CreateAutorCommand>
    {
        public CreateAutorCommandValidator()
        {
            RuleFor(p => p.Nombre)
              .NotEmpty().WithMessage("{Nombre} no puede estar vacio")
              .NotNull()
              .MaximumLength(50).WithMessage("{Nombre} no puede exceder los 50 caracteres");

        }
    }
}
