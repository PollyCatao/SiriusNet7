﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SiriusTech.Data.Models
{
    public partial class Boleto
    {
        [Key]
        [Column("idBoleto")]
        public int IdBoleto { get; set; }
        [Column("dataRegistro", TypeName = "datetime")]
        public DateTime? DataRegistro { get; set; }
        [Column("dcrBoleto")]
        [StringLength(50)]
        public string DcrBoleto { get; set; }
        [Column("idMovimentacao")]
        public int? IdMovimentacao { get; set; }

        [ForeignKey("IdMovimentacao")]
        [InverseProperty("Boleto")]
        public virtual Movimentacao IdMovimentacaoNavigation { get; set; }
    }
}