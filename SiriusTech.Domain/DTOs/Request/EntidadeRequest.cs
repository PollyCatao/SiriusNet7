using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiriusTech.Domain.DTOs.Request
{
    internal class EntidadeRequest
    {
        public int IdEntidade { get; set; }
        public DateTime? DataRegistro { get; set; }
        [StringLength(14)]
        [MinLength(14, ErrorMessage = "O Cpf deve ter no minimo, 14 caracteres.")]
        public string CpfCnpj { get; set; }
        [StringLength(50)]
        public string DcrEntidade { get; set; }
        [StringLength(50)]
        public string DcrCep { get; set; }
        [StringLength(50)]
        public string DcrEndereco { get; set; }
        [StringLength(50)]
        public string DcrNumero { get; set; }
        public int? IdCidade { get; set; }
        public int? IdBairro { get; set; }
        public int? IdEstado { get; set; }
        public int? IdPais { get; set; }
    }
}
