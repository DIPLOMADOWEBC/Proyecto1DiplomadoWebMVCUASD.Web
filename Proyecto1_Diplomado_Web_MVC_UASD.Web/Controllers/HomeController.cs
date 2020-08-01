using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto1_Diplomado_Web_MVC_UASD.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "<html><body>" +
                    "<h1>Universidad Autónoma de Santo Domingo (UASD)</h1>" +
                    "<p>DIPLOMANDO DESARROLLO WEB C#, MVC </p>" +
                    "</body></html>";
        }
        public string DiplomadoWeb()
        {

            return "<html><body>" +
                    "<h1>ESTUDIANTES: </h1>" +
                    "<p>Eudes Almánzar Then</p>" +
                    "<p>Justiniano Sánchez Pérez </p>" +
                    "<p>Martín Camilo Rodríguez </p>" +
                    "</body></html>";
        }
    }
}