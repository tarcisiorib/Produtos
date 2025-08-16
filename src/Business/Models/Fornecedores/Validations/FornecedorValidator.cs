using Business.Core.Validations.Documentos;
using FluentValidation;

namespace Business.Models.Fornecedores.Validations
{
    public class FornecedorValidator : AbstractValidator<Fornecedor>
    {
        public FornecedorValidator()
        {
            RuleFor(f => f.Nome)
                .NotEmpty()
                .WithMessage("{PropertyName} obrigatório.")
                .Length(2, 100)
                .WithMessage("{PropertyName} deve ter entre {MinLength} e {MaxLength} caracteres.");

            When(f => f.TipoFornecedor == TipoFornecedor.PessoaFisica, () =>
            {
                RuleFor(f => f.Documento.Length).Equal(ValidacaoCpf.TamanhoCpf)
                    .WithMessage("O campo precisa ter {ComparisonValue} caracteres.");
                RuleFor(f => ValidacaoCpf.Validar(f.Documento)).Equal(true)
                    .WithMessage("Documento inválido.");
            });

            When(f => f.TipoFornecedor == TipoFornecedor.PessoaJuridica, () =>
            {
                RuleFor(f => f.Documento.Length).Equal(ValidacaoCnpj.TamanhoCnpj)
                    .WithMessage("O campo precisa ter {ComparisonValue} caracteres.");
                RuleFor(f => ValidacaoCnpj.Validar(f.Documento)).Equal(true)
                    .WithMessage("Documento inválido.");
            });
        }
    }
}
