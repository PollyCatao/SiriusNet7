using SiriusTech.Data.Repositories;

namespace SiriusTech.Data.Services
{
    public  class TipoMovimentacaoServices
    {
        public TipoMovimentacaoRepository repositoryTipoMovimentacao { get; set; }

        public TipoMovimentacaoServices()
        {
            repositoryTipoMovimentacao = new TipoMovimentacaoRepository();
        }
    }
}
