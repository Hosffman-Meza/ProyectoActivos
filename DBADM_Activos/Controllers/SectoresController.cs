using DBADM_Activos.Models;
using DBADM_Activos.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBADM_Activos.Controllers
{
    public class SectoresController : Controller
    {
        Service1Client client = new Service1Client();

        // GET: Sectores
        public ActionResult Index()
        {
            var list = client.listSector();

            return View(list);
        }

        public ActionResult createSector()
        { 
            return View();
        }

        [HttpPost]
        public ActionResult createSector(SectoresCLS sec)
        {
            client.createSector(sec.IdSector, sec.DescripcionSector);

            return RedirectToAction("Index");
        }

        public ActionResult updateSector(string id)
        {
            SectoresCLS sect = new SectoresCLS();

            var item = client.detailSector(id);

            sect.IdSector = item.IdSector;
            sect.DescripcionSector = item.DescripcionSector;

            return View(sect);
        }

        [HttpPost]
        public ActionResult updateSector(SectoresCLS sec)
        {
            int st = (int)client.updateSector(sec.IdSector, sec.DescripcionSector, sec.NewIdSector).estado;

            return RedirectToAction("Index");
        }

        public ActionResult deleteSector(string id)
        {
            SectoresCLS sect = new SectoresCLS();

            var item = client.detailSector(id);

            sect.IdSector = item.IdSector;
            sect.DescripcionSector = item.DescripcionSector;

            return View(sect);
        }

        [HttpPost]
        public ActionResult deleteSector(SectoresCLS sec)
        {
            int st = (int)client.deleteSector(sec.IdSector).estado;

            return RedirectToAction("Index");
        }

        public ActionResult detailSector(string id)
        {
            SectoresCLS sect = new SectoresCLS();

            var item = client.detailSector(id);

            sect.IdSector = item.IdSector;
            sect.DescripcionSector = item.DescripcionSector;

            return View(sect);
        }
    }
}