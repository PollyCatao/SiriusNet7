using SiriusTech.Data.Repositories;

namespace SiriusTech.Data.Services
{
    public  class MovimentacaoServices
    {
        public RepositoryMovimentacao repositoryMovimentacao { get; set; }

        public RepositoryViewMovimentacao repositoryViewMovimentacao { get; set; }

        public RepositoryEntidade repositoryEntidade { get; set; }

        public RepositoryTipoMovimentacao repositoryTipoMovimentacao { get; set; }

        public MovimentacaoServices()
        {
            repositoryMovimentacao = new RepositoryMovimentacao();
            repositoryViewMovimentacao = new RepositoryViewMovimentacao();
            repositoryEntidade = new RepositoryEntidade();
            repositoryTipoMovimentacao = new RepositoryTipoMovimentacao();
           
        }
    }
}
