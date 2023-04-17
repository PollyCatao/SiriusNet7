using SiriusTech.Data.Interfaces.Repositories;
using SiriusTech.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiriusTech.Data.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IRepositoryProduto
    {      
        public ProdutoRepository(bool SaveChanges = true) : base(SaveChanges)
        {
                       
        }        
    }
}
