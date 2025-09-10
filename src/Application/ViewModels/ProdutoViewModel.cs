using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Application.ViewModels
{
    public class ProdutoViewModel
    {
        public ProdutoViewModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [StringLength(200, ErrorMessage = "{0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "{0} obrigatório")]
        [StringLength(100, ErrorMessage = "{0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }

        //[DisplayName("Imagem do Produto")]
        //public HttpPostedFileBase ImagemUpload { get; set; }

        public string Imagem { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public decimal Valor { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [DisplayName("Fornecedor")]
        public Guid FornecedorId { get; set; }

        //public FornecedorViewModel Fornecedor { get; set; }

        //public IEnumerable<FornecedorViewModel> Fornecedores { get; set; }
    }
}