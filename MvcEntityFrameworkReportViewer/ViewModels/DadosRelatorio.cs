using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcEntityFrameworkReportViewer.ViewModels
{
    public class DadosRelatorio
    {
        public int PedidoId { get; set; }
        public DateTime DataPedido { get; set; }
        public int ClienteId { get; set; }
        public string NomeCliente { get; set; }
        public int ProdutoId { get; set; }
        public string DescricaoProduto { get; set; }
        public double PrecoProduto { get; set; }
        public double Quantidade { get; set; }
        public double ValorTotal { get; set; }
    }
}