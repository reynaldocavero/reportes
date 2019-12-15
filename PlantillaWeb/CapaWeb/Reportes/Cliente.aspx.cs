using CapaEntidad;
using CapaNegocio;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWeb.Reportes
{
    public partial class Cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CNCliente cli = new CNCliente();
            IEnumerable<CECliente> data = cli.listaCliente("hola");
            ReportDocument rd = new ReportDocument();
            string path = Server.MapPath("~") + "/Reportes//rpt//ClienteReporte.rpt";

            rd.Load(path);
            rd.SetDataSource(data);
            CrystalReportViewer1.ReportSource = rd;
        }
    }
}