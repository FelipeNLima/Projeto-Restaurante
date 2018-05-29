using Highsoft.Web.Mvc.Charts;
using PagedList;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web.Mvc;
using WebSiteRestaurante.Models;
using Microsoft.Reporting.WebForms;


namespace WebSiteRestaurante.Controllers
{
    using DataSet.DataSetTaxaServicoTableAdapters;
    using DataSet;
    using System.Windows.Forms;
    using System.Web.UI.WebControls;
    using DataSet.DataSetRestauranteTableAdapters;
    using WebSiteRestaurante.DataSet.DataSetCouvertTableAdapters;
    using WebSiteRestaurante.DataSet.DataSetFinanceiroTableAdapters;
    using WebSiteRestaurante.DataSet.DataSetEstoqueTableAdapters;
    using WebSiteRestaurante.DataSet.DataSetConsumoTableAdapters;
    using Models;
    using WebSiteRestaurante.DataSet.DataSetTaxaServicoPorGarcomTableAdapters;

    public class HomeController : Controller
    {

        public ActionResult Principal()
        {
            return View();
        }

        #region LOGIN

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel usuario)
        {
            if (ModelState.IsValid) //verifica se é válido
            {
                LoginModel db = new LoginModel();
                var vLogin = db.cargo;
                bool certo = usuario.logar();

                TempData.Keep("LoginErrado");
                TempData["LoginErrado"] = !certo;

                if (certo)
                {
                    db.CarregarUsuarioPorLogin(usuario.login);
                    if (db.cargo.id_cargo == 1)
                    {
                        return RedirectToAction("Inicio");
                    }
                    else
                    {
                        return RedirectToAction("Login");
                    }
                }

            }
            return View();
        }

        #endregion

        #region INICIO

        public ActionResult Inicio()
        {
            var lista = PagamentoModel.faturamentoPorMes();
            
            List<ColumnSeriesData> faturamentoData = new List<ColumnSeriesData>();
            List<XAxis> mes = new List<XAxis>();

            lista.ForEach(p => faturamentoData.Add(new ColumnSeriesData { Y = p.Valor_total }));
            ViewData["faturamento"] = faturamentoData;

            var nomesDosMeses = new List<string>();
            lista.ForEach(x => nomesDosMeses.Add(x.data));

            ViewData["mes"] = nomesDosMeses;
            

            return View();
        }

        #endregion

        #region TAXA SERVIÇO

        public ActionResult RelatorioTaxaServico()
        {
            var lista = UsuarioModel.CarregarGarcom();

            foreach (var item in lista)
            {
                ViewBag.garcom = lista;
            }
            return View();
        }

        public ActionResult TaxaServicoPorGarcom()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TaxaServico(DateTime dataInicial, DateTime dataFinal, int? pagina)
        {
            var id_usuario = int.Parse(Request.Params["nomegarcom"]);

            if (id_usuario != 0)
            {
                List<TaxaServicoModel> relatorio = new List<TaxaServicoModel>();

                relatorio = TaxaServicoModel.RelatorioPorDataUsuario(dataInicial, dataFinal, id_usuario, false);
                ViewBag.dataInicial = dataInicial;
                ViewBag.dataFinal = dataFinal;
                ViewBag.idusuario = int.Parse(Request.Params["nomegarcom"]);

                return View("TaxaServicoPorGarcom", relatorio);

            }
            else
            {
                List<TaxaServicoModel> relatorio = new List<TaxaServicoModel>();

                relatorio = TaxaServicoModel.RelatorioPorData(dataInicial, dataFinal);
                ViewBag.dataInicial = dataInicial;
                ViewBag.dataFinal = dataFinal;
                ViewBag.idusuario = int.Parse(Request.Params["nomegarcom"]);
                return View("TaxaServico", relatorio);
            }


        }

        public ActionResult ReportViewerTaxaServico(DateTime dataInicial, DateTime dataFinal)
        {

            var ds = new DataSetTaxaServico();
            var dr = new DataSetRestaurante();

            var table = new TAXA_SERVICOTableAdapter();
            var table1 = new RESTAURANTETableAdapter();


            var datasource = new ReportDataSource
            {
                Name = "DataSetTaxaServico",
                Value = new BindingSource
                {
                    DataMember = "TAXA_SERVICO",
                    DataSource = ds
                }
            };

            var datasource1 = new ReportDataSource
            {
                Name = "DataSetRestaurante",
                Value = new BindingSource
                {
                    DataMember = "RESTAURANTE",
                    DataSource = dr
                }
            };

            table.Fill(ds.TAXA_SERVICO, dataInicial.ToShortDateString(), dataFinal.ToShortDateString());
            table1.Fill(dr.RESTAURANTE);

            var viewer = new ReportViewer();

            viewer.ProcessingMode = ProcessingMode.Local;
            viewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Relatorio\TaxaServico.rdlc";
            viewer.LocalReport.DataSources.Add(datasource);
            viewer.LocalReport.DataSources.Add(datasource1);

            viewer.ProcessingMode = ProcessingMode.Local;
            viewer.SizeToReportContent = true;
            viewer.ZoomMode = ZoomMode.FullPage;
            viewer.Width = Unit.Percentage(100);
            viewer.Height = Unit.Percentage(100);

            ViewBag.ReportViewer = viewer;

            return View();
        }

        public ActionResult ReportViewerTaxaServicoPorGarcom(DateTime dataInicial, DateTime dataFinal, int idusuario)
        {
            var ds1 = new DataSetTaxaServicoPorGarcom();
            var dr = new DataSetRestaurante();

            var table2 = new TAXA_SERVICO1TableAdapter();
            var table1 = new RESTAURANTETableAdapter();

            var datasource1 = new ReportDataSource
            {
                Name = "DataSetRestaurante",
                Value = new BindingSource
                {
                    DataMember = "RESTAURANTE",
                    DataSource = dr
                }
            };

            var datasource2 = new ReportDataSource
            {
                Name = "DataSetTaxaServicoPorGarcom",
                Value = new BindingSource
                {
                    DataMember = "TAXA_SERVICO",
                    DataSource = ds1
                }
            };

            table2.Fill(ds1.TAXA_SERVICO, dataInicial.ToShortDateString(), dataFinal.ToShortDateString(), 1, idusuario);
            table1.Fill(dr.RESTAURANTE);

            var viewer = new ReportViewer();

            viewer.ProcessingMode = ProcessingMode.Local;
            viewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Relatorio\TaxaServicoPorGarcom.rdlc";
            viewer.LocalReport.DataSources.Add(datasource2);
            viewer.LocalReport.DataSources.Add(datasource1);

            viewer.ProcessingMode = ProcessingMode.Local;
            viewer.SizeToReportContent = true;
            viewer.ZoomMode = ZoomMode.FullPage;
            viewer.Width = Unit.Percentage(100);
            viewer.Height = Unit.Percentage(100);

            ViewBag.ReportViewer = viewer;

            return View();

        }


        #endregion

        #region COUVERT ARTISTICO

        [HttpPost]
        public ActionResult CouvertArtistico(DateTime dataInicial, DateTime dataFinal, int? pagina)
        {
            List<TaxaCouvertArtisticoModel> relatorio = new List<TaxaCouvertArtisticoModel>();

            relatorio = TaxaCouvertArtisticoModel.RelatorioPorDataCouvert(dataInicial, dataFinal);
            ViewBag.dataInicial = dataInicial;
            ViewBag.dataFinal = dataFinal;

            //Definindo a paginação      
            int paginaQdteRegistros = 100;
            int paginaNumeroNavegacao = (pagina ?? 1);

            return View(relatorio.ToPagedList(paginaNumeroNavegacao, paginaQdteRegistros));
        }

        public ActionResult RelatorioCouvertArtistico()
        {
            return View();
        }

        public ActionResult ReportViewerCouvert(DateTime dataInicial, DateTime dataFinal)
        {

            var ds = new DataSetCouvert();
            var dr = new DataSetRestaurante();

            var table = new COUVERT_ARTISTICOTableAdapter();
            var table1 = new RESTAURANTETableAdapter();

            var datasource = new ReportDataSource
            {
                Name = "DataSetCouvert",
                Value = new BindingSource
                {
                    DataMember = "COUVERT_ARTISTICO",
                    DataSource = ds
                }
            };

            var datasource1 = new ReportDataSource
            {
                Name = "DataSetRestaurante",
                Value = new BindingSource
                {
                    DataMember = "RESTAURANTE",
                    DataSource = dr
                }
            };

            table.Fill(ds.COUVERT_ARTISTICO, dataInicial.ToShortDateString(), dataFinal.ToShortDateString());
            table1.Fill(dr.RESTAURANTE);

            var viewer = new ReportViewer();

            viewer.ProcessingMode = ProcessingMode.Local;
            viewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Relatorio\Couvert.rdlc";
            viewer.LocalReport.DataSources.Add(datasource);
            viewer.LocalReport.DataSources.Add(datasource1);

            viewer.ProcessingMode = ProcessingMode.Local;
            viewer.SizeToReportContent = true;
            viewer.ZoomMode = ZoomMode.FullPage;
            viewer.Width = Unit.Percentage(100);
            viewer.Height = Unit.Percentage(100);

            ViewBag.ReportViewer = viewer;

            return View();
        }
        #endregion

        #region FINANCEIRO
        public ActionResult RelatorioFinanceiro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Financeiro(DateTime dataInicial, DateTime dataFinal, int? pagina)
        {
            List<FinanceiroModel> relatorio = new List<FinanceiroModel>();

            relatorio = FinanceiroModel.RelatorioFinanceiro(dataInicial, dataFinal);
            ViewBag.dataInicial = dataInicial;
            ViewBag.dataFinal = dataFinal;

            //Definindo a paginação      
            int paginaQdteRegistros = 100;
            int paginaNumeroNavegacao = (pagina ?? 1);

            return View(relatorio.ToPagedList(paginaNumeroNavegacao, paginaQdteRegistros));


        }

        public ActionResult ReportViewerFinanceiro(DateTime dataInicial, DateTime dataFinal)
        {

            var ds = new DataSetFinanceiro();
            var dr = new DataSetRestaurante();

            var table = new PAGAMENTOTableAdapter();
            var table1 = new RESTAURANTETableAdapter();

            var datasource = new ReportDataSource
            {
                Name = "DataSetFinanceiro",
                Value = new BindingSource
                {
                    DataMember = "PAGAMENTO",
                    DataSource = ds
                }
            };

            var datasource1 = new ReportDataSource
            {
                Name = "DataSetRestaurante",
                Value = new BindingSource
                {
                    DataMember = "RESTAURANTE",
                    DataSource = dr
                }
            };

            table.Fill(ds.PAGAMENTO, dataInicial.ToShortDateString(), dataFinal.ToShortDateString());
            table1.Fill(dr.RESTAURANTE);

            var viewer = new ReportViewer();

            viewer.ProcessingMode = ProcessingMode.Local;
            viewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Relatorio\Financeiro.rdlc";
            viewer.LocalReport.DataSources.Add(datasource);
            viewer.LocalReport.DataSources.Add(datasource1);

            viewer.ProcessingMode = ProcessingMode.Local;
            viewer.SizeToReportContent = true;
            viewer.ZoomMode = ZoomMode.FullPage;
            viewer.Width = Unit.Percentage(100);
            viewer.Height = Unit.Percentage(100);

            ViewBag.ReportViewer = viewer;

            return View();
        }

        #endregion

        #region ESTOQUE

        public ActionResult RelatorioEstoqueEntrada()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EstoqueEntrada(DateTime dataInicial, DateTime dataFinal, int? pagina)
        {
            List<EstoqueModel> relatorio = new List<EstoqueModel>();

            relatorio = EstoqueModel.RelatorioEstoqueEntrada(dataInicial, dataFinal);
            ViewBag.dataInicial = dataInicial;
            ViewBag.dataFinal = dataFinal;

            //Definindo a paginação      
            int paginaQdteRegistros = 100;
            int paginaNumeroNavegacao = (pagina ?? 1);

            return View(relatorio.ToPagedList(paginaNumeroNavegacao, paginaQdteRegistros));
        }

        public ActionResult ReportViewerEstoqueEntrada(DateTime dataInicial, DateTime dataFinal)
        {

            var ds = new DataSetEstoque();
            var dr = new DataSetRestaurante();

            var table = new ESTOQUETableAdapter();
            var table1 = new RESTAURANTETableAdapter();

            var datasource = new ReportDataSource
            {
                Name = "DataSetEstoque",
                Value = new BindingSource
                {
                    DataMember = "ESTOQUE",
                    DataSource = ds
                }
            };

            var datasource1 = new ReportDataSource
            {
                Name = "DataSetRestaurante",
                Value = new BindingSource
                {
                    DataMember = "RESTAURANTE",
                    DataSource = dr
                }
            };

            table.Fill(ds.ESTOQUE, dataInicial.ToShortDateString(), dataFinal.ToShortDateString());
            table1.Fill(dr.RESTAURANTE);

            var viewer = new ReportViewer();

            viewer.ProcessingMode = ProcessingMode.Local;
            viewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Relatorio\EstoqueEntrada.rdlc";
            viewer.LocalReport.DataSources.Add(datasource);
            viewer.LocalReport.DataSources.Add(datasource1);

            viewer.ProcessingMode = ProcessingMode.Local;
            viewer.SizeToReportContent = true;
            viewer.ZoomMode = ZoomMode.FullPage;
            viewer.Width = Unit.Percentage(100);
            viewer.Height = Unit.Percentage(100);

            ViewBag.ReportViewer = viewer;

            return View();
        }


        public ActionResult RelatorioEstoqueSaida()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EstoqueSaida(DateTime dataInicial, DateTime dataFinal, int? pagina)
        {
            List<ConsumoModel> relatorio = new List<ConsumoModel>();

            relatorio = ConsumoModel.RelatorioEstoqueSaida(dataInicial, dataFinal);
            ViewBag.dataInicial = dataInicial;
            ViewBag.dataFinal = dataFinal;

            //Definindo a paginação      
            int paginaQdteRegistros = 100;
            int paginaNumeroNavegacao = (pagina ?? 1);

            return View(relatorio.ToPagedList(paginaNumeroNavegacao, paginaQdteRegistros));
        }

        public ActionResult ReportViewerEstoqueSaida(DateTime dataInicial, DateTime dataFinal)
        {

            var ds = new DataSetConsumo();
            var dr = new DataSetRestaurante();

            var table = new CONSUMOTableAdapter();
            var table1 = new RESTAURANTETableAdapter();

            var datasource = new ReportDataSource
            {
                Name = "DataSetConsumo",
                Value = new BindingSource
                {
                    DataMember = "CONSUMO",
                    DataSource = ds
                }
            };

            var datasource1 = new ReportDataSource
            {
                Name = "DataSetRestaurante",
                Value = new BindingSource
                {
                    DataMember = "RESTAURANTE",
                    DataSource = dr
                }
            };

            table.Fill(ds.CONSUMO, dataInicial, dataFinal);
            table1.Fill(dr.RESTAURANTE);

            var viewer = new ReportViewer();

            viewer.ProcessingMode = ProcessingMode.Local;
            viewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Relatorio\EstoqueSaída.rdlc";
            viewer.LocalReport.DataSources.Add(datasource);
            viewer.LocalReport.DataSources.Add(datasource1);

            viewer.ProcessingMode = ProcessingMode.Local;
            viewer.SizeToReportContent = true;
            viewer.ZoomMode = ZoomMode.FullPage;
            viewer.Width = Unit.Percentage(100);
            viewer.Height = Unit.Percentage(100);

            ViewBag.ReportViewer = viewer;

            return View();
        }

        #endregion


    }
}