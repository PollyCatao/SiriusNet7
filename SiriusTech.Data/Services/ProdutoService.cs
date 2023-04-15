using SiriusTech.Data.Repositories;

namespace SiriusTech.Data.Services
{
    public  class ProdutoServices
    {
        public RepositoryProduto repositoryProduto { get; set; }

        public ProdutoServices()
        {
            repositoryProduto = new RepositoryProduto();
        }
    }
}
