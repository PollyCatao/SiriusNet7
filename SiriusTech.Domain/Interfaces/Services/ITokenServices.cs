using Microsoft.Identity.Client;
using SiriusTech.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiriusTech.Domain.Interfaces.Services
{
    public interface ITokenServices
    {
        string CreateToken(Usuario usuario);
    }
}
