using Microsoft.EntityFrameworkCore;
using SiriusTech.Data.Context;
using SiriusTech.Data.Interfaces.Repositories;
using SiriusTech.Data.Models;

namespace SiriusTech.Data.Repositories
{
    public class EntidadeRepository : BaseRepository<Entidade>, IRepositoryEntidade
    {      
        private readonly SiriusTechContext _context;

        public EntidadeRepository(SiriusTechContext context,bool SaveChanges = true) : base(SaveChanges)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Alterar(Entidade entidade)
        {
            _context.Entry(entidade).State = EntityState.Modified;
        }

        public void Excluir(Entidade entidade)
        {
            _context.Entidade.Remove(entidade);
        }

        public void Incluir(Entidade entidade)
        {
            _context.Entidade.Add(entidade);
        }

        public async Task<Entidade> SelecionarByPk(int id)
        {
            return await _context.Entidade.Where(x => x.IdEntidade == id).FirstOrDefaultAsync();

        }

        public async Task<IEnumerable<Entidade>> SelecionarTodos()
        {
            return await _context.Entidade.ToListAsync();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
