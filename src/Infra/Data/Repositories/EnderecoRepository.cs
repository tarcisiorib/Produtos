using Business.Models.Fornecedores;
using Infra.Data.Context;
using System;
using System.Threading.Tasks;

namespace Infra.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(ProdutosDbContext db) : base(db) { }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await ObterPorId(fornecedorId);
        }
    }
}
