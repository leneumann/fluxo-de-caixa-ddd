using FluentValidation;
using FluentValidation.Results;

namespace FluxoDeCaixa.Application
{
    public abstract class Command
    {
        public bool Valid { get; private set; }
        public bool Invalid => !Valid;
        public ValidationResult ValidationResult { get; private set; }

        public abstract IValidator GetValidator();
        public bool Validate()
        {
            ValidationResult = GetValidator().Validate(this);
            return Valid = ValidationResult.IsValid;
        }
    }
}