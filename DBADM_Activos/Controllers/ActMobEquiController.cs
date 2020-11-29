using DBADM_Activos.Models;
using DBADM_Activos.ServiceReference1;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.EnterpriseServices.CompensatingResourceManager;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBADM_Activos.Controllers
{
    public class ActMobEquiController : Controller
    {

        Service1Client client = new Service1Client();

        // GET: ActMobEqui
        public ActionResult Index()
        {
            var list = client.listActMobEquipo();

            return View(list);
        }

        public ActionResult createActMobEqui()
        {
            return View();
        }

        [HttpPost]
        public ActionResult createActMobEqui(ActMobEquiCLS act)
        {
            client.createActMobEquipo(act.IDMobiliarioEquipoOficina, act.NombreMobiliarioEquiposOficina, act.CaracterísticasDelBien, act.CostosDeAdquisición, act.FechaDeAdquisición, act.MarcaDelBien, act.ReferenciasTécnicasDelBien, act.TiempoDeVidaEstimada, act.CodificacionCostoDeAdquisición, act.CodificaciónParaDepreciaciónAcumulada, act.CaracterísticasDelBien, act.CodificaciónDelControlador, act.IdEntidad, act.IdMetodo_Depreciación, act.IdDepartamento, (double)act.ValorDeDepreciaciónAnual, (DateTime)act.FechaDepresiado);

            return RedirectToAction("Index");
        }

        public ActionResult updateActMobEqui(int id)
        {
            ActMobEquiCLS actm = new ActMobEquiCLS();

            //SE DEBE CREAR OTRO SP DE DETALLE QUE TRAIGA (ENTIDAD, METDEPRE, DEPARTAMENTO) COMO INT (tiene que se esta)
            //O PONERLE UN SELECT AL UPDATE QUE RETORNE EL CODIGO DE LA ENTIDAD MEDIANTE EL NOMBRE

            var item = client.detailActMobEquipo(id);

            actm.IDMobiliarioEquipoOficina = item.IDMobiliarioEquipoOficina;
            actm.NombreMobiliarioEquiposOficina = item.NombreMobiliarioEquiposOficina;
            actm.CaracterísticasDelBien = item.CaracterísticasDelBien;
            actm.CostosDeAdquisición = item.CostosDeAdquisición;
            actm.FechaDeAdquisición = item.FechaDeAdquisición;
            actm.FechaDepresiado = item.FechaDepresiado;
            actm.MarcaDelBien = item.MarcaDelBien;
            actm.ReferenciasTécnicasDelBien = item.ReferenciasTécnicasDelBien;
            actm.TiempoDeVidaEstimada = item.TiempoDeVidaEstimada;
            actm.ValorDeDepreciaciónAnual = item.ValorDeDepreciaciónAnual;
            actm.CodificacionCostoDeAdquisición = item.CodificacionCostoDeAdquisición;
            actm.CodificaciónParaDepreciaciónAcumulada = item.CodificaciónParaDepreciaciónAcumulada;
            actm.CaracterísticasGeneralesDelActivo = item.CaracterísticasGeneralesDelActivo;
            actm.CodificaciónDelControlador = item.CodificaciónDelControlador;
            actm.CreadoPorMobEquiOfic = item.CreadoPorMobEquiOfic;
            //actm.IdEntidad = item.IdEntidad;
            //actm.IdMetodo_Depreciación = item.IdMetodo_Depreciación;
            //actm.IdDepartamento = item.IdDepartamento;

            return View(actm);
        }

        [HttpPost]
        public ActionResult updateActMobEqui(ActMobEquiCLS act)
        {
            int st = (int)client.editActMobEquipo(act.IDMobiliarioEquipoOficina, act.NombreMobiliarioEquiposOficina, act.CaracterísticasDelBien, act.CostosDeAdquisición, act.FechaDeAdquisición, act.MarcaDelBien, act.ReferenciasTécnicasDelBien, act.TiempoDeVidaEstimada, act.CodificacionCostoDeAdquisición, act.CodificaciónParaDepreciaciónAcumulada, act.CaracterísticasGeneralesDelActivo, act.CodificaciónDelControlador, act.IdEntidad, act.IdMetodo_Depreciación, act.IdDepartamento, (DateTime)act.FechaDepresiado).estado;

            return RedirectToAction("Index");
        }

        public ActionResult deleteActMobEqui(int id)
        {
            ActMobEquiCLS actm = new ActMobEquiCLS();

            //SE DEBE CREAR OTRO SP DE DETALLE QUE TRAIGA (ENTIDAD, METDEPRE, DEPARTAMENTO) COMO INT (tiene que se esta)
            //O PONERLE UN SELECT AL UPDATE QUE RETORNE EL CODIGO DE LA ENTIDAD MEDIANTE EL NOMBRE

            var item = client.detailActMobEquipo(id);

            actm.IDMobiliarioEquipoOficina = item.IDMobiliarioEquipoOficina;
            actm.NombreMobiliarioEquiposOficina = item.NombreMobiliarioEquiposOficina;
            actm.CaracterísticasDelBien = item.CaracterísticasDelBien;
            actm.CostosDeAdquisición = item.CostosDeAdquisición;
            actm.FechaDeAdquisición = item.FechaDeAdquisición;
            actm.FechaDepresiado = item.FechaDepresiado;
            actm.MarcaDelBien = item.MarcaDelBien;
            actm.ReferenciasTécnicasDelBien = item.ReferenciasTécnicasDelBien;
            actm.TiempoDeVidaEstimada = item.TiempoDeVidaEstimada;
            actm.ValorDeDepreciaciónAnual = item.ValorDeDepreciaciónAnual;
            actm.CodificacionCostoDeAdquisición = item.CodificacionCostoDeAdquisición;
            actm.CodificaciónParaDepreciaciónAcumulada = item.CodificaciónParaDepreciaciónAcumulada;
            actm.CaracterísticasGeneralesDelActivo = item.CaracterísticasGeneralesDelActivo;
            actm.CodificaciónDelControlador = item.CodificaciónDelControlador;
            actm.CreadoPorMobEquiOfic = item.CreadoPorMobEquiOfic;
            //actm.IdEntidad = item.IdEntidad;
            //actm.IdMetodo_Depreciación = item.IdMetodo_Depreciación;
            //actm.IdDepartamento = item.IdDepartamento;

            return View(actm);
        }

        [HttpPost]
        public ActionResult deleteActMobEqui(ActMobEquiCLS act)
        {
            int st = (int)client.deleteActMobEquipo(act.IDMobiliarioEquipoOficina).estado;

            return RedirectToAction("Index");
        }

        public ActionResult detailActMobEqui(int id)
        {
            ActMobEquiCLS actm = new ActMobEquiCLS();

            var item = client.detailActMobEquipo(id);

            actm.IDMobiliarioEquipoOficina = item.IDMobiliarioEquipoOficina;
            actm.NombreMobiliarioEquiposOficina = item.NombreMobiliarioEquiposOficina;
            actm.CaracterísticasDelBien = item.CaracterísticasDelBien;
            actm.CostosDeAdquisición = item.CostosDeAdquisición;
            actm.FechaDeAdquisición = item.FechaDeAdquisición;
            actm.FechaDepresiado = item.FechaDepresiado;
            actm.MarcaDelBien = item.MarcaDelBien;
            actm.ReferenciasTécnicasDelBien = item.ReferenciasTécnicasDelBien;
            actm.TiempoDeVidaEstimada = item.TiempoDeVidaEstimada;
            actm.ValorDeDepreciaciónAnual = item.ValorDeDepreciaciónAnual;
            actm.CodificacionCostoDeAdquisición = item.CodificacionCostoDeAdquisición;
            actm.CodificaciónParaDepreciaciónAcumulada = item.CodificaciónParaDepreciaciónAcumulada;
            actm.CaracterísticasGeneralesDelActivo = item.CaracterísticasGeneralesDelActivo;
            actm.CodificaciónDelControlador = item.CodificaciónDelControlador;
            actm.CreadoPorMobEquiOfic = item.CreadoPorMobEquiOfic;
            actm.Entidad = item.Entidad;
            actm.Metodo_Depreciación = item.Metodo_Depreciación;
            actm.Departamento = item.Departamento;

            return View(actm);
        }
    }
}