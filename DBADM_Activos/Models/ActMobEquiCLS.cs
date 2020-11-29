using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBADM_Activos.Models
{
    public class ActMobEquiCLS
    {
        public int IDMobiliarioEquipoOficina { get; set; }
        public string NombreMobiliarioEquiposOficina { get; set; }
        public string CaracterísticasDelBien { get; set; }
        public double CostosDeAdquisición { get; set; }
        public System.DateTime FechaDeAdquisición { get; set; }
        public Nullable<DateTime> FechaDepresiado { get; set; }
        public string MarcaDelBien { get; set; }
        public string ReferenciasTécnicasDelBien { get; set; }
        public int TiempoDeVidaEstimada { get; set; }
        public Nullable<double> ValorDeDepreciaciónAnual { get; set; }
        public string CodificacionCostoDeAdquisición { get; set; }
        public string CodificaciónParaDepreciaciónAcumulada { get; set; }
        public string CaracterísticasGeneralesDelActivo { get; set; }
        public string CodificaciónDelControlador { get; set; }
        public string CreadoPorMobEquiOfic { get; set; }
        public int IdEntidad { get; set; }
        public int IdMetodo_Depreciación { get; set; }
        public int IdDepartamento { get; set; }
        public string Entidad { get; set; }
        public string Metodo_Depreciación { get; set; }
        public string Departamento { get; set; }
    }
}