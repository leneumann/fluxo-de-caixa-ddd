using FluentValidation;
using FluentValidation.Results;

namespace FluxoDeCaixa.Application
{
    public abstract class Command
    {
        public bool Valid { get; private set; }
        public bool Invalid => !Valid;
        public ValidationResult ValidationResult { get; private set; }

        public bool Validate<T>(T command, AbstractValidator<T> validator)
        {
            ValidationResult = validator.Validate(command);
            return Valid = ValidationResult.IsValid;
        }
    }
}