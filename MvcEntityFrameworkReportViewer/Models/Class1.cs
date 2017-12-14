using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcEntityFrameworkReportViewer.Models
{
    public class Cliente
    {
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ClienteId { get; set; }

        public string Nome { get; set; }
    }

    public class Produto
    {
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ProdutoId { get; set; }

        public string Descricao { get; set; }
        public double Preco { get; set; }
    }

    public class Pedido
    {
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int PedidoId { get; set; }

        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public DateTime DataPedido { get; set; }
        public virtual ICollection<ItemPedido> ItensPedido { get; set; }
    }

    public class ItemPedido
    {
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ItemPedidoId { get; set; }

        public int PedidoId { get; set; }
        public virtual Pedido Pedido { get; set; }
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public double Quantidade { get; set; }
        public double ValorTotal { get; set; }
    }
}