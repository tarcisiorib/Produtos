using Business.Core.Notificacoes;
using Business.Core.Services;
using Business.Models.Produtos.Validations;
using System;
using System.Threading.Tasks;

namespace Business.Models.Produtos.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository,
                              INotifier notificator) : base(notificator)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task Adicionar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidator(), produto)) return;

            await _produtoRepository.Adicionar(produto);
        }

        public async Task Atualizar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidator(), produto)) return;

            await _produtoRepository.Atualizar(produto);
        }

        public async Task Remover(Guid id) => await _produtoRepository.Remover(id);

        public void Dispose() => _produtoRepository?.Dispose();
    }
}
