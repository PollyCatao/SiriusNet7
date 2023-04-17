using SiriusTech.Data.Repositories;

namespace SiriusTech.Data.Services
{
    public  class EntidadeServices
    {
        public EntidadeRepository repositoryEntidade { get; set; }

        public EntidadeServices()
        {
            repositoryEntidade = new RepositoryEntidade();
        }
    }
}
