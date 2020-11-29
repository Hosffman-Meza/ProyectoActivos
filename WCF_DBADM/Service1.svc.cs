using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_DBADM
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        ControlActivosEntities_ db = new ControlActivosEntities_();

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        //FUNCIONES ACTIVO MOBILIARRIO Y EQUIPO
        public List<SP_ActMobEquipo_toList_Result> listActMobEquipo()
        {
            return db.SP_ActMobEquipo_toList_Result().ToList();
        }

        public SP_ActMobEquipo_detail_Result detailActMobEquipo(int id)
        {
            return db.SP_ActMobEquipo_detail_Result(id).FirstOrDefault();
        }

        public SP_ActMobEquipo_insert_Result createActMobEquipo(int Id, string name, string caracteristicas, double costoAdqui, DateTime fechaAdqui, string marca, string refTecnica, int vidaEstimada, string codCostoAdqui, string codDepreAcu, string catGenerales, string codControlador, int idEntidad, int idMetodoDepre, int idDepActivoEqui, double valorDepreAnual, DateTime fechaDepresiado)
        {
            return db.SP_ActMobEquipo_insert_Result(Id, name, caracteristicas, costoAdqui, fechaAdqui, marca, refTecnica, vidaEstimada, codCostoAdqui, codDepreAcu, catGenerales, codControlador, idEntidad, idMetodoDepre, idDepActivoEqui, valorDepreAnual, fechaDepresiado).FirstOrDefault();
        }

        public SP_ActMobEquipo_update_Result editActMobEquipo(int Id, string name, string caracteristicas, double costoAdqui, DateTime fechaAdqui, string marca, string refTecnica, int vidaEstimada, string codCostoAdqui, string codDepreAcu, string catGenerales, string codControlador, int idEntidad, int idMetodoDepre, int idDepActivoEqui, DateTime fechaDepresiado)
        {
            return db.SP_ActMobEquipo_update_Result(Id, name, caracteristicas, costoAdqui, fechaAdqui, marca, refTecnica, vidaEstimada, codCostoAdqui, codDepreAcu, catGenerales, codControlador, idEntidad, idMetodoDepre, idDepActivoEqui, fechaDepresiado).FirstOrDefault();
        }

        public SP_ActMobEquipo_delete_Result deleteActMobEquipo(int id)
        {
            return db.SP_ActMobEquipo_delete_Result(id).FirstOrDefault();
        }

        //FUNCIONES ACTIVO TERRONO
        public List<SP_ActTerreno_toList_Result> listActTerreno()
        {
            return db.SP_ActTerreno_toList_Result().ToList();
        }

        public SP_ActTerreno_detail_Result detailActTerreno(int id)
        {
            return db.SP_ActTerreno_detail_Result(id).FirstOrDefault();
        }

        public SP_ActTerreno_insert_Result createActTerreno(int id, DateTime fechaAdqui, double tamanio, double costoAdqui, string exReevealuacion, int tasaCrecimiento, string codContabl, int idEntidad, string idSector, int tipoEdi, double valorPlus, DateTime fechaReevaluacion)
        {
            return db.SP_ActTerreno_insert_Result(id, fechaAdqui, tamanio, costoAdqui, exReevealuacion, tasaCrecimiento, codContabl, idEntidad, idSector, tipoEdi, valorPlus, fechaReevaluacion).FirstOrDefault();
        }

        public SP_ActTerreno_update_Result editActTerreno(int id, DateTime fechaAdqui, double tamanio, double costoAdqui, string exReevealuacion, int tasaCrecimiento, string codContabl, int idEntidad, string idSector, int tipoEdi, DateTime fechaAjusteCredito, double valorPlus, double costoActual, DateTime fechaReevaluacion)
        {
            return db.SP_ActTerreno_update_Result(id, fechaAdqui, tamanio, costoAdqui, exReevealuacion, tasaCrecimiento, codContabl, idEntidad, idSector, tipoEdi, fechaAjusteCredito, valorPlus, costoActual, fechaReevaluacion).FirstOrDefault();
        }

        public SP_ActTerreno_delete_Result1 deleteActTerreno(int id)
        {
            return db.SP_ActTerreno_delete_Result(id).FirstOrDefault();
        }

        //FUNCIONES DEPARTAMENTOS ACTIVO Y EQUIPO
        public List<SP_DepActEqui_toList_Result> listDepActEqui()
        {
            return db.SP_DepActEqui_toList_Result().ToList();
        }

        public SP_DepActEqui_detail_Result detailDepActEqui(int id)
        {
            return db.SP_DepActEqui_detail_Result(id).FirstOrDefault();
        }

        public SP_DepActEqui_insert_Result createDepActEqui(string nombre)
        {
            return db.SP_DepActEqui_insert_Result(nombre).FirstOrDefault();
        }

        public SP_DepActEqui_update_Result updateDepActEqui(int id, string name)
        {
            return db.SP_DepActEqui_update_Result(id, name).FirstOrDefault();
        }

        public SP_DepActEqui_delete_Result deleteDepActEqui(int id)
        {
            return db.SP_DepActEqui_delete_Result(id).FirstOrDefault();
        }

        //FUNCIONES ENTIDADES
        public List<SP_Entidad_toList_Result> listEntidad()
        {
            return db.SP_Entidad_toList_Result().ToList();
        }

        public SP_Entidad_detail_Result detailEntidad(int id)
        {
            return db.SP_Entidad_detail_Result(id).FirstOrDefault();
        }

        public SP_Entidad_insert_Result createEntidad(string nombre, string direccion, string telefono, string email, string RUC)
        {
            return db.SP_Entidad_insert_Result(nombre, direccion, telefono, email, RUC).FirstOrDefault();
        }

        public SP_Entidad_update_Result updateEntidad(int id, string nombre, string direccion, string telefono, string email, string RUC)
        {
            return db.SP_Entidad_update_Result(id, nombre, direccion, telefono, email, RUC).FirstOrDefault();
        }

        public SP_Entidad_delete_Result deleteEntidad(int id)
        {
            return db.SP_Entidad_delete_Result(id).FirstOrDefault();
        }

        //FUNCIONES METODO DE DEPRESICIACION
        public List<SP_MetDepre_toList_Result> listMetDepre()
        {
            return db.SP_MetDepre_toList_Result().ToList();
        }

        public SP_MetDepre_deatail_Result detailMetDepre(int id)
        {
            return db.SP_MetDepre_deatail_Result(id).FirstOrDefault();
        }

        public SP_MetDepre_insert_Result createMetDepre(string nombre, string caracteristica)
        {
            return db.SP_MetDepre_insert_Result(nombre, caracteristica).FirstOrDefault();
        }

        public SP_MetDepre_update_Result updateMetDepre(int id, string nombre, string caracteristica)
        {
            return db.SP_MetDepre_update_Result(id, nombre, caracteristica).FirstOrDefault();
        }

        public SP_MetDepre_delete_Result deleteMetDepre(int id)
        {
            return db.SP_MetDepre_delete_Result(id).FirstOrDefault();
        }

        //FUNCIONES SECTORES
        public List<SP_Sectores_toList_Result> listSector()
        {
            return db.SP_Sectores_toList_Result().ToList();
        }

        public SP_Sectores_detail_Result detailSector(string id)
        {
            return db.SP_Sectores_detail_Result(id).FirstOrDefault();
        }

        public SP_Sectores_insert_Result createSector(string id, string descripcion)
        {
            return db.SP_Sectores_insert_Result(id, descripcion).FirstOrDefault();
        }

        public SP_Sectores_update_Result updateSector(string id, string descripcion, string newId)
        {
            return db.SP_Sectores_update_Result(id, descripcion, newId).FirstOrDefault();
        }

        public SP_Sectores_delete_Result deleteSector(string id)
        {
            return db.SP_Sectores_delete_Result(id).FirstOrDefault();
        }

        //FUNCION TIPO DE EDIFICIO
        public List<SP_TipoEdificioConstru_toList_Result> listTipoEdiConstru()
        {
            return db.SP_TipoEdificioConstru_toList_Result().ToList();
        }

        public SP_TipoEdificioConstru_detail_Result detailTipoEdiConstru(int id)
        {
            return db.SP_TipoEdificioConstru_detail_Result(id).FirstOrDefault();
        }

        public SP_TipoEdificioConstru_insert_Result createTipoEdiConstru(string nombre, string descripcion)
        {
            return db.SP_TipoEdificioConstru_insert_Result(nombre, descripcion).FirstOrDefault();
        }

        public SP_TipoEdificioConstru_update_Result updateTipoEdiConstru(int id, string nombre, string descripcion)
        {
            return db.SP_TipoEdificioConstru_update_Result(id, nombre, descripcion).FirstOrDefault();
        }

        public SP_TipoEdificioConstru_delte_Result deleteTipoEdiConstru(int id)
        {
            return db.SP_TipoEdificioConstru_delte_Result(id).FirstOrDefault();
        }
    }
}
