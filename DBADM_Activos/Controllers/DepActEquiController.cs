using DBADM_Activos.Models;
using DBADM_Activos.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBADM_Activos.Controllers
{
    public class DepActEquiController : Controller
    {
        Service1Client client = new Service1Client();

        // GET: DepActEqui
        public ActionResult Index()
        {
            var list = client.listDepActEqui();

            return View(list);
        }

        public ActionResult createDepActEqui()
        {
            return View();
        }

        [HttpPost]
        public ActionResult createDepActEqui(DepActEquiCLS dep)
        {
            client.createDepActEqui(dep.NombreDepartamentoAsignado);

            return RedirectToAction("Index");
        }

        public ActionResult updateDepActEqui(int id)
        {
            DepActEquiCLS depa = new DepActEquiCLS();

            var item = client.detailDepActEqui(id);

            depa.IdDepartamentoActivoEquipo = item.IdDepartamentoActivoEquipo;
            depa.NombreDepartamentoAsignado = item.NombreDepartamentoAsignado;

            return View(depa);
        }

        [HttpPost]
        public ActionResult updateDepActEqui(DepActEquiCLS dep)
        {
            int st = (int)client.updateDepActEqui(dep.IdDepartamentoActivoEquipo, dep.NombreDepartamentoAsignado).estado;

            return RedirectToAction("Index");
        }

        public ActionResult deleteDepActEqui(int id)
        {
            DepActEquiCLS depa = new DepActEquiCLS();

            var item = client.detailDepActEqui(id);

            depa.IdDepartamentoActivoEquipo = item.IdDepartamentoActivoEquipo;
            depa.NombreDepartamentoAsignado = item.NombreDepartamentoAsignado;

            return View(depa);
        }

        [HttpPost]
        public ActionResult deleteDepActEqui(DepActEquiCLS dep)
        {
            int st = (int)client.deleteDepActEqui(dep.IdDepartamentoActivoEquipo).estado;

            return RedirectToAction("Index");
        }

        public ActionResult detailDepActEqui(int id)
        {
            DepActEquiCLS depa = new DepActEquiCLS();

            var item = client.detailDepActEqui(id);

            depa.IdDepartamentoActivoEquipo = item.IdDepartamentoActivoEquipo;
            depa.NombreDepartamentoAsignado = item.NombreDepartamentoAsignado;

            return View(depa);
        }
    }
}