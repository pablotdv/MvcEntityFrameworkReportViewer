using Microsoft.Reporting.WebForms;
using MvcEntityFrameworkReportViewer.Models;
using MvcEntityFrameworkReportViewer.Reports;
using MvcEntityFrameworkReportViewer.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcEntityFrameworkReportViewer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var contexto = new Contexto())
            {
                LocalReport relat = new LocalReport
                {
                    //caminho do arquivo rdlc
                    ReportPath = Server.MapPath("~/Reports/Report1.rdlc"),
                    EnableExternalImages = true,
                };

                relat.DataSources.Add(new ReportDataSource
                {
                    Name = "DataSet1",
                    Value = new ExemploReport().Dados().Where(a=>a.ClienteId == 1)
                });

                string reportType = "PDF";

                //configurações da página ex: margin, top, left ...
                string deviceInfo =
                "<DeviceInfo>" +
                "<OutputFormat>PDF</OutputFormat>" +
                "<PageWidth>8.27in</PageWidth>" +
                "<PageHeight>11.69in</PageHeight>" +
                "<MarginTop>0.19685in</MarginTop>" +
                "<MarginLeft>0.19685in</MarginLeft>" +
                "<MarginRight>0.19685in</MarginRight>" +
                "<MarginBottom>0.19685in</MarginBottom>" +
                "</DeviceInfo>";

                byte[] bytes;
                //Renderizando o relatório o bytes
                bytes = relat.Render(reportType, deviceInfo, out string mimeType, out string encoding, out string fileNameExtension, out string[] streams, out Warning[] warnings);

                return File(bytes, mimeType);
            }            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}