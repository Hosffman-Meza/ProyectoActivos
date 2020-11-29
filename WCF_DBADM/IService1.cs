using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_DBADM
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        List<SP_ActMobEquipo_toList_Result> listActMobEquipo();

        [OperationContract]
        SP_ActMobEquipo_detail_Result detailActMobEquipo(int id);

        [OperationContract]
        SP_ActMobEquipo_insert_Result createActMobEquipo(int Id, string name, string caracteristicas, double costoAdqui, DateTime fechaAdqui, string marca, string refTecnica, int vidaEstimada, string codCostoAdqui, string codDepreAcu, string catGenerales, string codControlador, int idEntidad, int idMetodoDepre, int idDepActivoEqui, double valorDepreAnual, DateTime fechaDepresiado);

        [OperationContract]
        SP_ActMobEquipo_update_Result editActMobEquipo(int Id, string name, string caracteristicas, double costoAdqui, DateTime fechaAdqui, string marca, string refTecnica, int vidaEstimada, string codCostoAdqui, string codDepreAcu, string catGenerales, string codControlador, int idEntidad, int idMetodoDepre, int idDepActivoEqui, DateTime fechaDepresiado);

        [OperationContract]
        SP_ActMobEquipo_delete_Result deleteActMobEquipo(int id);

        [OperationContract]
        List<SP_ActTerreno_toList_Result> listActTerreno();

        [OperationContract]
        SP_ActTerreno_detail_Result detailActTerreno(int id);

        [OperationContract]
        SP_ActTerreno_insert_Result createActTerreno(int id, DateTime fechaAdqui, double tamanio, double costoAdqui, string exReevealuacion, int tasaCrecimiento, string codContabl, int idEntidad, string idSector, int tipoEdi, double valorPlus, DateTime fechaReevaluacion);

        [OperationContract]
        SP_ActTerreno_update_Result editActTerreno(int id, DateTime fechaAdqui, double tamanio, double costoAdqui, string exReevealuacion, int tasaCrecimiento, string codContabl, int idEntidad, string idSector, int tipoEdi, DateTime fechaAjusteCredito, double valorPlus, double costoActual, DateTime fechaReevaluacion);

        [OperationContract]
        SP_ActTerreno_delete_Result1 deleteActTerreno(int id);

        [OperationContract]
        List<SP_DepActEqui_toList_Result> listDepActEqui();

        [OperationContract]
        SP_DepActEqui_detail_Result detailDepActEqui(int id);

        [OperationContract]
        SP_DepActEqui_insert_Result createDepActEqui(string nombre);

        [OperationContract]
        SP_DepActEqui_update_Result updateDepActEqui(int id, string name);

        [OperationContract]
        SP_DepActEqui_delete_Result deleteDepActEqui(int id);

        [OperationContract]
        List<SP_Entidad_toList_Result> listEntidad();

        [OperationContract]
        SP_Entidad_detail_Result detailEntidad(int id);

        [OperationContract]
        SP_Entidad_insert_Result createEntidad(string nombre, string direccion, string telefono, string email, string RUC);

        [OperationContract]
        SP_Entidad_update_Result updateEntidad(int id, string nombre, string direccion, string telefono, string email, string RUC);

        [OperationContract]
        SP_Entidad_delete_Result deleteEntidad(int id);

        [OperationContract]
        List<SP_MetDepre_toList_Result> listMetDepre();

        [OperationContract]
        SP_MetDepre_deatail_Result detailMetDepre(int id);

        [OperationContract]
        SP_MetDepre_insert_Result createMetDepre(string nombre, string caracteristica);

        [OperationContract]
        SP_MetDepre_update_Result updateMetDepre(int id, string nombre, string caracteristica);

        [OperationContract]
        SP_MetDepre_delete_Result deleteMetDepre(int id);

        [OperationContract]
        List<SP_Sectores_toList_Result> listSector();

        [OperationContract]
        SP_Sectores_detail_Result detailSector(string id);

        [OperationContract]
        SP_Sectores_insert_Result createSector(string id, string descripcion);

        [OperationContract]
        SP_Sectores_update_Result updateSector(string id, string descripcion, string newId);

        [OperationContract]
        SP_Sectores_delete_Result deleteSector(string id);

        [OperationContract]
        List<SP_TipoEdificioConstru_toList_Result> listTipoEdiConstru();

        [OperationContract]
        SP_TipoEdificioConstru_detail_Result detailTipoEdiConstru(int id);

        [OperationContract]
        SP_TipoEdificioConstru_insert_Result createTipoEdiConstru(string nombre, string descripcion);

        [OperationContract]
        SP_TipoEdificioConstru_update_Result updateTipoEdiConstru(int id, string nombre, string descripcion);

        [OperationContract]
        SP_TipoEdificioConstru_delte_Result deleteTipoEdiConstru(int id);
    }
}
