using DBADM_Activos.Models;
using DBADM_Activos.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBADM_Activos.Controllers
{
    public class TipoEdificioController : Controller
    {
        Service1Client client = new Service1Client();

        // GET: TipoEdificio
        public ActionResult Index()
        {
            var list = client.listTipoEdiConstru();

            return View(list);
        }

        public ActionResult createTipoEdi()
        {
            return View();
        }

        [HttpPost]
        public ActionResult createTipoEdi(TipoEdificioConstruCLS edi)
        {
            client.createTipoEdiConstru(edi.NombreTipoEdificio, edi.DescripcionTipo);

            return RedirectToAction("Index");
        }

        public ActionResult updateTipoEdi(int id)
        {
            TipoEdificioConstruCLS tedi = new TipoEdificioConstruCLS();

            var item = client.detailTipoEdiConstru(id);

            tedi.IdTipoEdificioConstruido = item.IdTipoEdificioConstruido;
            tedi.NombreTipoEdificio = item.NombreTipoEdificio;
            tedi.DescripcionTipo = item.DescripcionTipo;

            return View(tedi);
        }

        [HttpPost]
        public ActionResult updateTipoEdi(TipoEdificioConstruCLS edi)
        {
            int st = (int)client.updateTipoEdiConstru(edi.IdTipoEdificioConstruido, edi.NombreTipoEdificio, edi.DescripcionTipo).estado;

            return RedirectToAction("Index");
        }

        public ActionResult deleteTipoEdi(int id)
        {
            TipoEdificioConstruCLS tedi = new TipoEdificioConstruCLS();

            var item = client.detailTipoEdiConstru(id);

            tedi.IdTipoEdificioConstruido = item.IdTipoEdificioConstruido;
            tedi.NombreTipoEdificio = item.NombreTipoEdificio;
            tedi.DescripcionTipo = item.DescripcionTipo;

            return View(tedi);
        }

        [HttpPost]
        public ActionResult deleteTipoEdi(TipoEdificioConstruCLS edi)
        {
            int st = (int)client.deleteTipoEdiConstru(edi.IdTipoEdificioConstruido).estado;

            return RedirectToAction("Index");
        }

        public ActionResult detailTipoEdi(int id)
        {
            TipoEdificioConstruCLS tedi = new TipoEdificioConstruCLS();

            var item = client.detailTipoEdiConstru(id);

            tedi.IdTipoEdificioConstruido = item.IdTipoEdificioConstruido;
            tedi.NombreTipoEdificio = item.NombreTipoEdificio;
            tedi.DescripcionTipo = item.DescripcionTipo;

            return View(tedi);
        }
    }
}