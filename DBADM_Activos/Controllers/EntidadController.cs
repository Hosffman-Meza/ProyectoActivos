using DBADM_Activos.Models;
using DBADM_Activos.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBADM_Activos.Controllers
{
    public class EntidadController : Controller
    {

        Service1Client client = new Service1Client();

        // GET: Entidad
        public ActionResult Index()
        {
            var list = client.listEntidad();

            return View(list);
        }

        public ActionResult createEntidad()
        {
            return View();
        }

        [HttpPost]
        public ActionResult createEntidad(EntidadCLS ent)
        {
            client.createEntidad(ent.NombreEntidad, ent.DirecciónEntidad, ent.TelefonoEntidad, ent.EmailEntidad, ent.RUCEntidad);

            return RedirectToAction("Index");
        }

        public ActionResult updateEntidad(int id)
        {
            EntidadCLS entd = new EntidadCLS();

            var item = client.detailEntidad(id);

            entd.IDEntidad = item.IDEntidad;
            entd.NombreEntidad = item.NombreEntidad;
            entd.DirecciónEntidad = item.DirecciónEntidad;

            return View(entd);
        }

        [HttpPost]
        public ActionResult updateEntidad(EntidadCLS ent)
        {
            int st = (int)client.updateEntidad(ent.IDEntidad, ent.NombreEntidad, ent.DirecciónEntidad, ent.TelefonoEntidad, ent.EmailEntidad, ent.RUCEntidad).estado;

            return RedirectToAction("Index");
        }

        public ActionResult deleteEntidad(int id)
        {
            EntidadCLS entd = new EntidadCLS();

            var item = client.detailEntidad(id);

            entd.IDEntidad = item.IDEntidad;
            entd.NombreEntidad = item.NombreEntidad;
            entd.DirecciónEntidad = item.DirecciónEntidad;

            return View(entd);
        }

        [HttpPost]
        public ActionResult deleteEntidad(EntidadCLS ent)
        {
            int st = (int)client.deleteEntidad(ent.IDEntidad).estado;

            return RedirectToAction("Index");
        }

        public ActionResult detailEntidad(int id)
        {
            EntidadCLS entd = new EntidadCLS();

            var item = client.detailEntidad(id);

            entd.IDEntidad = item.IDEntidad;
            entd.NombreEntidad = item.NombreEntidad;
            entd.DirecciónEntidad = item.DirecciónEntidad;

            return View(entd);
        }
    }
}