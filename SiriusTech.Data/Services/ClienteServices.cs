using SiriusTech.Data.Repositories;

namespace SiriusTech.Data.Services
{
    public  class ClienteServices
    {
        public RepositoryCliente repositoryCliente { get; set; }

        public ClienteServices()
        {
            repositoryCliente = new RepositoryCliente();
        }
    }
}
