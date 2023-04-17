using SiriusTech.Data.Interfaces.Repositories;
using SiriusTech.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiriusTech.Data.Repositories
{
    public class TipoMovimentacaoRepository : BaseRepository<TipoMovimentacao>, IRepositoryTipoMovimentacao
    {      
        public TipoMovimentacaoRepository(bool SaveChanges = true) : base(SaveChanges)
        {
                       
        }        
    }
}
