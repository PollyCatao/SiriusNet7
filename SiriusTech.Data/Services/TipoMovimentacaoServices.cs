using SiriusTech.Data.Repositories;

namespace SiriusTech.Data.Services
{
    public  class TipoMovimentacaoServices
    {
        public RepositoryTipoMovimentacao repositoryTipoMovimentacao { get; set; }

        public TipoMovimentacaoServices()
        {
            repositoryTipoMovimentacao = new RepositoryTipoMovimentacao();
        }
    }
}
