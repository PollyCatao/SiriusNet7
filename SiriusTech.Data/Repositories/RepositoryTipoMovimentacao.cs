﻿using SiriusTech.Data.Interfaces;
using SiriusTech.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiriusTech.Data.Repositories
{
    public class RepositoryTipoMovimentacao : RepositoryBase<TipoMovimentacao>, IRepositoryTipoMovimentacao
    {      
        public RepositoryTipoMovimentacao(bool SaveChanges = true) : base(SaveChanges)
        {
                       
        }        
    }
}