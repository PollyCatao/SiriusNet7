using SiriusTech.Data.Repositories;

namespace SiriusTech.Data.Services
{
    public  class ProdutoServices
    {
        public ProdutoRepository repositoryProduto { get; set; }

        public ProdutoServices()
        {
            repositoryProduto = new ProdutoRepository();
        }
    }
}
