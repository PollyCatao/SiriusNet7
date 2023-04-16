using SiriusTech.Data.Interfaces;
using SiriusTech.Data.Repositories;

namespace SiriusTech.Data.Services
{
    public  class ViewMovimentacaoServices
    {
        public RepositoryViewMovimentacao repositoryViewMovimentacao { get; set; }

        public ViewMovimentacaoServices()
        {
            repositoryViewMovimentacao = new RepositoryViewMovimentacao();
        }
    }
}
