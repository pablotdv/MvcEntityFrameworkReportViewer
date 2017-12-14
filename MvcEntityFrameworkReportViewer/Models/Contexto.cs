using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcEntityFrameworkReportViewer.Models
{
    public class Contexto : System.Data.Entity.DbContext
    {
        public System.Data.Entity.DbSet<Models.Cliente> Clientes { get; set; }
        public System.Data.Entity.DbSet<Models.Produto> Produtos { get; set; }
        public System.Data.Entity.DbSet<Models.Pedido> Pedidos { get; set; }
        public System.Data.Entity.DbSet<Models.ItemPedido> ItensPedido { get; set; }
    }
}