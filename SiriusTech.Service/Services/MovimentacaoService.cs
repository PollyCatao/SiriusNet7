using SiriusTech.Data.Repositories;

namespace SiriusTech.Data.Services
{
    public  class MovimentacaoServices
    {
        public MovimentacaoRepository repositoryMovimentacao { get; set; }

        public ViewMovimentacaoRepository repositoryViewMovimentacao { get; set; }

        public EntidadeRepository repositoryEntidade { get; set; }

        public TipoMovimentacaoRepository repositoryTipoMovimentacao { get; set; }

        public MovimentacaoServices()
        {
            repositoryMovimentacao = new MovimentacaoRepository();
            repositoryViewMovimentacao = new ViewMovimentacaoRepository();
            repositoryEntidade = new RepositoryEntidade();
            repositoryTipoMovimentacao = new TipoMovimentacaoRepository();
           
        }
    }
}
