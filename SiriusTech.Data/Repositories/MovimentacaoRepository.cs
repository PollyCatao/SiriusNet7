using SiriusTech.Data.Interfaces.Repositories;
using SiriusTech.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiriusTech.Data.Repositories
{
    public class MovimentacaoRepository : BaseRepository<Movimentacao>, IRepositoryMovimentacao
    {      
        public MovimentacaoRepository(bool SaveChanges = true) : base(SaveChanges)
        {
                       
        }        
    }
}
