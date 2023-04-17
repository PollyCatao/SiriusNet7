using SiriusTech.Data.Interfaces;
using SiriusTech.Data.Repositories;

namespace SiriusTech.Data.Services
{
    public  class ViewMovimentacaoServices
    {
        public ViewMovimentacaoRepository repositoryViewMovimentacao { get; set; }

        public ViewMovimentacaoServices()
        {
            repositoryViewMovimentacao = new ViewMovimentacaoRepository();
        }
    }
}
