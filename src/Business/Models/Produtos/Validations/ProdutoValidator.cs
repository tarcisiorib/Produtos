using FluentValidation;

namespace Business.Models.Produtos.Validations
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(p => p.Nome)
                .NotEmpty()
                .WithMessage("{PropertyName} obrigatório.")
                .Length(2, 200)
                .WithMessage("{PropertyName} deve ter entre {MinLength} e {MaxLength} caracteres.");

            RuleFor(p => p.Descricao)
                .NotEmpty()
                .WithMessage("{PropertyName} obrigatório.")
                .Length(2, 1000)
                .WithMessage("{PropertyName} deve ter entre {MinLength} e {MaxLength} caracteres.");

            RuleFor(p => p.Valor)
                .GreaterThan(0)
                .WithMessage("{PropertyName} deve ser maior que zero.");
        }
    }
}
