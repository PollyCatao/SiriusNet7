using SiriusTech.Data.Repositories;

namespace SiriusTech.Data.Services
{
    public  class EntidadeServices
    {
        public RepositoryEntidade repositoryEntidade { get; set; }

        public EntidadeServices()
        {
            repositoryEntidade = new RepositoryEntidade();
        }
    }
}
