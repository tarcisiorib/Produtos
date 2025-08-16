using FluentValidation;

namespace Business.Models.Fornecedores.Validations
{
    public class EnderecoValidator : AbstractValidator<Endereco>
    {
        public EnderecoValidator()
        {
            RuleFor(e => e.Logradouro)
                .NotEmpty()
                .WithMessage("{PropertyName} obrigatório.")
                .Length(2, 200)
                .WithMessage("{PropertyName} deve ter entre {MinLength} e {MaxLength} caracteres.");
            RuleFor(e => e.Bairro)
                .NotEmpty()
                .WithMessage("{PropertyName} obrigatório.")
                .Length(2, 100)
                .WithMessage("{PropertyName} deve ter entre {MinLength} e {MaxLength} caracteres.");
            RuleFor(e => e.Cep)
                .NotEmpty()
                .WithMessage("{PropertyName} obrigatório.")
                .Length(8)
                .WithMessage("{PropertyName} deve ter {MaxLength} caracteres.");
            RuleFor(e => e.Cidade)
                .NotEmpty()
                .WithMessage("{PropertyName} obrigatório.")
                .Length(2, 100)
                .WithMessage("{PropertyName} deve ter entre {MinLength} e {MaxLength} caracteres.");
            RuleFor(e => e.Estado)
                .NotEmpty()
                .WithMessage("{PropertyName} obrigatório.")
                .Length(2, 50)
                .WithMessage("{PropertyName} deve ter entre {MinLength} e {MaxLength} caracteres.");
            RuleFor(e => e.Numero)
                .NotEmpty()
                .WithMessage("{PropertyName} obrigatório.")
                .Length(1, 50)
                .WithMessage("{PropertyName} deve ter entre {MinLength} e {MaxLength} caracteres.");
        }
    }
}
