using DBADM_Activos.Models;
using DBADM_Activos.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBADM_Activos.Controllers
{
    public class MetDepreciacionController : Controller
    {
        Service1Client client = new Service1Client();

        // GET: MetDepreciacion
        public ActionResult Index()
        {
            var list = client.listMetDepre();

            return View(list);
        }

        public ActionResult createMetDepre()
        {
            return View();
        }

        [HttpPost]
        public ActionResult createMetDepre(MetDepreciacionCLS met)
        {
            client.createMetDepre(met.NombreMetodoDepreciación, met.CaracteristicaMetodo);

            return RedirectToAction("Index");
        }

        public ActionResult updateMetDepre(int id)
        {
            MetDepreciacionCLS metd = new MetDepreciacionCLS();

            var item = client.detailMetDepre(id);

            metd.IdMetodosDepreciación = item.IdMetodosDepreciación;
            metd.NombreMetodoDepreciación = item.NombreMetodoDepreciación;
            metd.CaracteristicaMetodo = item.CaracteristicaMetodo;

            return View(metd);
        }

        [HttpPost]
        public ActionResult updateMetDepre(MetDepreciacionCLS met)
        {
            int st = (int)client.updateMetDepre(met.IdMetodosDepreciación, met.NombreMetodoDepreciación, met.CaracteristicaMetodo).estado;

            return RedirectToAction("Index");
        }

        public ActionResult deleteMetDepre(int id)
        {
            MetDepreciacionCLS metd = new MetDepreciacionCLS();

            var item = client.detailMetDepre(id);

            metd.IdMetodosDepreciación = item.IdMetodosDepreciación;
            metd.NombreMetodoDepreciación = item.NombreMetodoDepreciación;
            metd.CaracteristicaMetodo = item.CaracteristicaMetodo;

            return View(metd);
        }

        [HttpPost]
        public ActionResult deleteMetDepre(MetDepreciacionCLS met)
        {
            int st = (int)client.deleteMetDepre(met.IdMetodosDepreciación).estado;

            return RedirectToAction("Index");
        }

        public ActionResult detailMetDepre(int id)
        {
            MetDepreciacionCLS metd = new MetDepreciacionCLS();

            var item = client.detailMetDepre(id);

            metd.IdMetodosDepreciación = item.IdMetodosDepreciación;
            metd.NombreMetodoDepreciación = item.NombreMetodoDepreciación;
            metd.CaracteristicaMetodo = item.CaracteristicaMetodo;

            return View(metd);
        }
    }
}