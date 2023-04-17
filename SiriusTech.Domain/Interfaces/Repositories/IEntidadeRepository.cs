
namespace SiriusTech.Domain.Interfaces.Repositories
{
    public interface IEntidadeRepository : IModelRepository<Entidade>
    {
        void Incluir(Entidade entidade);
        void Alterar(Entidade entidade);
        void Excluir(Entidade entidade);
        Task<Entidade> SelecionarByPk(int id);
        Task<IEnumerable<Entidade>> SelecionarTodos();
        Task<bool> SaveAllAsync();

    }
}
