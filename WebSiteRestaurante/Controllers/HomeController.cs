using DotNet.Highcharts;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Helpers;
using DotNet.Highcharts.Options;
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
            Highcharts columnChart = new Highcharts("columnchart");
            columnChart.InitChart(new Chart()
            {
                Type = ChartTypes.Column,
                BackgroundColor = new BackColorOrGradient(Color.AliceBlue),
                Style = "fontWeight: 'bold', fontSize: '17px'",
                BorderColor = Color.LightBlue,
                BorderRadius = 0,
                BorderWidth = 2
            });
            columnChart.SetTitle(new Title()
            {
                Text = "Relatório Financeiro por Mês"
            });
            columnChart.SetSubtitle(new Subtitle()
            {
                Text = "Gráfico Por Mês"
            });
            columnChart.SetXAxis(new XAxis()
            {
                Type = AxisTypes.Category,
                Title = new XAxisTitle() { Text = "Mêses", Style = "fontWeight: 'bold', fontSize: '17px'" },
                //Categories = new[] { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" }
                Categories = new[] { "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012" }
            });
            columnChart.SetYAxis(new YAxis()
            {
                Title = new YAxisTitle()
                {
                    Text = "Valor",
                    Style = "fontWeight: 'bold', fontSize: '17px'"
                },
                ShowFirstLabel = true,
                ShowLastLabel = true,
                Min = 0
            });
            columnChart.SetLegend(new Legend
            {
                Enabled = true,
                BorderColor = Color.CornflowerBlue,
                BorderRadius = 6,
                BackgroundColor = new BackColorOrGradient(ColorTranslator.FromHtml("#FFADD8E6"))
            });
            columnChart.SetSeries(new Series[]
            {
                 new Series{
                    Name = "Santos",
                    Data = new Data(new object[] { 89, 59, 64, 62, 45, 49, 53, 53, 57 })
                },
                new Series()
                {
                    Name = "São Paulo",
                    Data = new Data(new object[] { 82, 58, 78, 77, 75, 65, 59, 66, 50 })
                }
            }
            );
            return View(columnChart);
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
            var lista = UsuarioModel.CarregarGarcom();
            var id_usuario = int.Parse(Request.Params["nomegarcom"]);

            if (id_usuario != 0)
            {
                List<TaxaServicoModel> relatorio = new List<TaxaServicoModel>();

                relatorio = TaxaServicoModel.RelatorioPorDataUsuario(dataInicial, dataFinal, id_usuario, false);
                ViewBag.dataInicial = dataInicial;
                ViewBag.dataFinal = dataFinal;

                return View("TaxaServicoPorGarcom", relatorio);

            }
            else
            {
                List<TaxaServicoModel> relatorio = new List<TaxaServicoModel>();

                relatorio = TaxaServicoModel.RelatorioPorData(dataInicial, dataFinal, id_usuario, true);
                ViewBag.dataInicial = dataInicial;
                ViewBag.dataFinal = dataFinal;

                return View("TaxaServico", relatorio);
            }


        }

        public ActionResult ReportViewerTaxaServico(DateTime dataInicial, DateTime dataFinal, int id_usuario)
        {

            var ds = new DataSetTaxaServico();
            var ds1 = new DataSetTaxaServico();
            var dr = new DataSetRestaurante();

            var table = new TAXA_SERVICOTableAdapter();
            var table1 = new RESTAURANTETableAdapter();
            var table2 = new TAXA_SERVICO1TableAdapter();

            var datasource = new ReportDataSource
            {
                Name = "DataSetTaxaServico",
                Value = new BindingSource
                {
                    DataMember = "TAXA_SERVICO",
                    DataSource = ds
                }
            };

            var datasource2 = new ReportDataSource
            {
                Name = "DataSetTaxaServico",
                Value = new BindingSource
                {
                    DataMember = "TAXA_SERVICO1",
                    DataSource = ds1
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

            table.Fill(ds.TAXA_SERVICO, dataInicial.ToShortDateString(), dataFinal.ToShortDateString(), 0, id_usuario);
            table1.Fill(dr.RESTAURANTE);
            table2.Fill(ds1.TAXA_SERVICO1, dataInicial.ToShortDateString(), dataFinal.ToShortDateString(), 1,id_usuario);

            var viewer = new ReportViewer();

            viewer.ProcessingMode = ProcessingMode.Local;
            viewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Relatorio\TaxaServico.rdlc";
            viewer.LocalReport.DataSources.Add(datasource);
            viewer.LocalReport.DataSources.Add(datasource1);
            viewer.LocalReport.DataSources.Add(datasource2);

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
            int paginaQdteRegistros = 2;
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
            int paginaQdteRegistros = 2;
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
            int paginaQdteRegistros = 2;
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
            int paginaQdteRegistros = 2;
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