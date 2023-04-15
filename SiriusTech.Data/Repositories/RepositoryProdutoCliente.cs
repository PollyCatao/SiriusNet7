﻿using SiriusTech.Data.Interfaces;
using SiriusTech.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiriusTech.Data.Repositories
{
    public class RepositoryProdutoCliente : RepositoryBase<ProdutoCliente>, IRepositoryProdutoCliente
    {      
        public RepositoryProdutoCliente(bool SaveChanges = true) : base(SaveChanges)
        {
                       
        }        
    }
}