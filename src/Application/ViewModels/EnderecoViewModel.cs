using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Application.ViewModels
{
    public class EnderecoViewModel
    {
        public EnderecoViewModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [StringLength(200, ErrorMessage = "{0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [StringLength(200, ErrorMessage = "{0} deve ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [StringLength(200, ErrorMessage = "{0} deve ter entre {2} e {1} caracteres", MinimumLength = 8)]
        public string Cep { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [StringLength(200, ErrorMessage = "{0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [StringLength(200, ErrorMessage = "{0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [StringLength(200, ErrorMessage = "{0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Estado { get; set; }

        [HiddenInput]
        public Guid FornecedorId { get; set; }
    }
}