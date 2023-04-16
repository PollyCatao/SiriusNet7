﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SiriusTech.Data.Models
{
    public partial class Cotacao
    {
        public Cotacao()
        {
            MovimentacaoItem = new HashSet<MovimentacaoItem>();
        }

        [Key]
        [Column("idCotacao")]
        public int IdCotacao { get; set; }
        [Column("dataRegistro", TypeName = "datetime")]
        public DateTime? DataRegistro { get; set; }
        [Column("dcrCotacao")]
        [StringLength(50)]
        public string DcrCotacao { get; set; }

        [InverseProperty("IdCotacaoNavigation")]
        public virtual ICollection<MovimentacaoItem> MovimentacaoItem { get; set; }
    }
}