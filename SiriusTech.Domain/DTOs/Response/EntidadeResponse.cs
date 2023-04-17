using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiriusTech.Domain.DTOs.Response
{
    public class EntidadeResponse
    {       
        public int IdEntidade { get; set; }
        public DateTime? DataRegistro { get; set; }
        [StringLength(100)]
        [MinLength(14)]
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
