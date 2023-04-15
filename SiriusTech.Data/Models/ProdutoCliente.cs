﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SiriusTech.Data.Models
{
    [Table("Produto_Cliente")]
    public partial class ProdutoCliente
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("idProduto")]
        public int? IdProduto { get; set; }
        [Column("idCliente")]
        public int? IdCliente { get; set; }
        [Column("dataVenda", TypeName = "datetime")]
        public DateTime? DataVenda { get; set; }

        [ForeignKey("IdCliente")]
        [InverseProperty("ProdutoCliente")]
        public virtual Cliente IdClienteNavigation { get; set; }
        [ForeignKey("IdProduto")]
        [InverseProperty("ProdutoCliente")]
        public virtual Produto IdProdutoNavigation { get; set; }
    }
}