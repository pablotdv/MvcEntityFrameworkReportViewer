using MvcEntityFrameworkReportViewer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcEntityFrameworkReportViewer.Reports
{
    public class ExemploReport
    {
        public List<DadosRelatorio> Dados() => new List<DadosRelatorio>()
        {
                new DadosRelatorio { ClienteId = 1 },
                new DadosRelatorio { ClienteId = 2 }
        };
    }
}