using DBADM_Activos.Models;
using DBADM_Activos.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBADM_Activos.Controllers
{
    public class ActTerrenoController : Controller
    {
        Service1Client client = new Service1Client();

        // GET: ActTerreno
        public ActionResult Index()
        {
            var list = client.listActTerreno();

            return View(list);
        }

        public ActionResult createActTerremo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult createActTerremo(ActTerrenoCLS act)
        {
            client.createActTerreno(act.NoRegistroActivosTerrenos, act.FechaDeAdquisicionActivosTerrenos, act.TamañoDelTerrenoVsqr2ActivosTerrenos, act.CostoDeAdquisiciónActivosTerrenos, act.ExperimentoDeReevaluaciónParaPlusvalía, act.TasaCrecimiento, act.CódigoContableActivosTerrenos, act.IdEntidad, act.Sector, act.IdEdificio, (double)act.ValorDeLaPlusvalía, (DateTime)act.FechaDeReevaluacionAplicada);

            return RedirectToAction("Index");
        }

        public ActionResult updateActTerreno(int id)
        {
            ActTerrenoCLS actt = new ActTerrenoCLS();

            //SE DEBE CREAR OTRO SP DE DETALLE QUE TRAIGA (ENTIDAD, METDEPRE, DEPARTAMENTO) COMO INT (tiene que se esta)
            //O PONERLE UN SELECT AL UPDATE QUE RETORNE EL CODIGO DE LA ENTIDAD MEDIANTE EL NOMBRE

            //VER QUE DEVUELVE SECTOR SI ID O OTRO CAMPO

            var item = client.detailActTerreno(id);

            actt.NoRegistroActivosTerrenos = item.NoRegistroActivosTerrenos;
            actt.FechaDeAdquisicionActivosTerrenos = item.FechaDeAdquisicionActivosTerrenos;
            actt.TamañoDelTerrenoVsqr2ActivosTerrenos = item.TamañoDelTerrenoVsqr2ActivosTerrenos;
            actt.CostoDeAdquisiciónActivosTerrenos = item.CostoDeAdquisiciónActivosTerrenos;
            actt.ExperimentoDeReevaluaciónParaPlusvalía = item.ExperimentoDeReevaluaciónParaPlusvalía;
            actt.FechaDeReevaluacionAplicada = item.FechaDeReevaluacionAplicada;
            actt.TasaCrecimiento = item.TasaCrecimiento;
            actt.ValorDeLaPlusvalía = item.ValorDeLaPlusvalía;
            actt.CostoTotalActualDelTerreno = item.CostoTotalActualDelTerreno;
            actt.CódigoContableActivosTerrenos = item.CódigoContableActivosTerrenos;
            actt.FechaDelAjustePorCréditoDePlusvalía = item.FechaDelAjustePorCréditoDePlusvalía;
            actt.CreadoPorTerrenos = item.CreadoPorTerrenos;
            //actt.IdEntidad = item.IdEntidad;
            actt.Sector = item.Sector;
            //actt.IdEdificio = item.IdEdificio;

            return View(actt);
        }

        [HttpPost]
        public ActionResult updateActTerreno(ActTerrenoCLS act)
        {
            int st = (int)client.editActTerreno(act.NoRegistroActivosTerrenos, act.FechaDeAdquisicionActivosTerrenos, act.TamañoDelTerrenoVsqr2ActivosTerrenos, act.CostoDeAdquisiciónActivosTerrenos, act.ExperimentoDeReevaluaciónParaPlusvalía, act.TasaCrecimiento, act.CódigoContableActivosTerrenos, act.IdEntidad, act.Sector, act.IdEdificio, (DateTime)act.FechaDelAjustePorCréditoDePlusvalía, (double)act.ValorDeLaPlusvalía, act.CostoTotalActualDelTerreno, (DateTime)act.FechaDeReevaluacionAplicada).estado;

            return RedirectToAction("Index");
        }

        public ActionResult deleteActTerreno(int id)
        {
            ActTerrenoCLS actt = new ActTerrenoCLS();

            //SE DEBE CREAR OTRO SP DE DETALLE QUE TRAIGA (ENTIDAD, METDEPRE, DEPARTAMENTO) COMO INT (tiene que se esta)
            //O PONERLE UN SELECT AL UPDATE QUE RETORNE EL CODIGO DE LA ENTIDAD MEDIANTE EL NOMBRE

            //VER QUE DEVUELVE SECTOR SI ID O OTRO CAMPO

            var item = client.detailActTerreno(id);

            actt.NoRegistroActivosTerrenos = item.NoRegistroActivosTerrenos;
            actt.FechaDeAdquisicionActivosTerrenos = item.FechaDeAdquisicionActivosTerrenos;
            actt.TamañoDelTerrenoVsqr2ActivosTerrenos = item.TamañoDelTerrenoVsqr2ActivosTerrenos;
            actt.CostoDeAdquisiciónActivosTerrenos = item.CostoDeAdquisiciónActivosTerrenos;
            actt.ExperimentoDeReevaluaciónParaPlusvalía = item.ExperimentoDeReevaluaciónParaPlusvalía;
            actt.FechaDeReevaluacionAplicada = item.FechaDeReevaluacionAplicada;
            actt.TasaCrecimiento = item.TasaCrecimiento;
            actt.ValorDeLaPlusvalía = item.ValorDeLaPlusvalía;
            actt.CostoTotalActualDelTerreno = item.CostoTotalActualDelTerreno;
            actt.CódigoContableActivosTerrenos = item.CódigoContableActivosTerrenos;
            actt.FechaDelAjustePorCréditoDePlusvalía = item.FechaDelAjustePorCréditoDePlusvalía;
            actt.CreadoPorTerrenos = item.CreadoPorTerrenos;
            //actt.IdEntidad = item.IdEntidad;
            actt.Sector = item.Sector;
            //actt.IdEdificio = item.IdEdificio;

            return View(actt);
        }

        [HttpPost]
        public ActionResult deleteActTereno(ActTerrenoCLS act)
        {
            int st = (int)client.deleteActTerreno(act.NoRegistroActivosTerrenos).estado;

            return RedirectToAction("Index");
        }

        public ActionResult detailActTerreno(int id)
        {
            ActTerrenoCLS actt = new ActTerrenoCLS();

            var item = client.detailActTerreno(id);

            actt.NoRegistroActivosTerrenos = item.NoRegistroActivosTerrenos;
            actt.FechaDeAdquisicionActivosTerrenos = item.FechaDeAdquisicionActivosTerrenos;
            actt.TamañoDelTerrenoVsqr2ActivosTerrenos = item.TamañoDelTerrenoVsqr2ActivosTerrenos;
            actt.CostoDeAdquisiciónActivosTerrenos = item.CostoDeAdquisiciónActivosTerrenos;
            actt.ExperimentoDeReevaluaciónParaPlusvalía = item.ExperimentoDeReevaluaciónParaPlusvalía;
            actt.FechaDeReevaluacionAplicada = item.FechaDeReevaluacionAplicada;
            actt.TasaCrecimiento = item.TasaCrecimiento;
            actt.ValorDeLaPlusvalía = item.ValorDeLaPlusvalía;
            actt.CostoTotalActualDelTerreno = item.CostoTotalActualDelTerreno;
            actt.CódigoContableActivosTerrenos = item.CódigoContableActivosTerrenos;
            actt.FechaDelAjustePorCréditoDePlusvalía = item.FechaDelAjustePorCréditoDePlusvalía;
            actt.CreadoPorTerrenos = item.CreadoPorTerrenos;
            actt.Entidad = item.Entidad;
            actt.Sector = item.Sector;
            actt.Edificio = item.Edificio;

            return View(actt);
        }


    }
}