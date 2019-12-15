using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaWeb.Controllers
{
    public class DocumentoController : Controller
    {
        // GET: Documento
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult listaCliente(string xml)
        {

            CNCliente cliente = new CNCliente();
            IEnumerable<CECliente> data = cliente.listaCliente(xml);
            return Json(data,JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult registraCliente(string xml)
        {

            CNCliente cliente = new CNCliente();
            IEnumerable<CECliente> data = cliente.registraCliente(xml);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult reporteCliente(string xml)
        {

            string server = HttpContext.Request.Url.Authority;
          
            return Json(server + "/Reportes/" + xml+".aspx");
            
        }


    }
}