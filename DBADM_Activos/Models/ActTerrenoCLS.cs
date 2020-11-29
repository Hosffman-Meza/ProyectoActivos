using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBADM_Activos.Models
{
    public class ActTerrenoCLS
    {
        public int NoRegistroActivosTerrenos { get; set; }
        public System.DateTime FechaDeAdquisicionActivosTerrenos { get; set; }
        public double TamañoDelTerrenoVsqr2ActivosTerrenos { get; set; }
        public double CostoDeAdquisiciónActivosTerrenos { get; set; }
        public string ExperimentoDeReevaluaciónParaPlusvalía { get; set; }
        public Nullable<System.DateTime> FechaDeReevaluacionAplicada { get; set; }
        public int TasaCrecimiento { get; set; }
        public Nullable<double> ValorDeLaPlusvalía { get; set; }
        public double CostoTotalActualDelTerreno { get; set; }
        public string CódigoContableActivosTerrenos { get; set; }
        public Nullable<System.DateTime> FechaDelAjustePorCréditoDePlusvalía { get; set; }
        public string CreadoPorTerrenos { get; set; }
        public int IdEntidad { get; set; }
        public int IdSector { get; set; }
        public int IdEdificio { get; set; }
        public string Entidad { get; set; }
        public string Sector { get; set; }
        public string Edificio { get; set; }
    }

}