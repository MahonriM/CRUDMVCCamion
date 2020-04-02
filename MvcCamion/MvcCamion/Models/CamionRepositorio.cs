using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace MvcCamion.Models
{
    public class CamionRepositorio: ICamion
    {
        public List<Camion> obtenerCamiones()
        {
            List<Camion> lstCamion = new List<Camion>();
            DataTable dtcamion = new DataTable();
            dtcamion = BaseHelper.ejecutarSelect("spselectcamion", CommandType.StoredProcedure);
            for (int i = 0; i < dtcamion.Rows.Count; i++)
            {
                Camion camTemp = new Camion();
                camTemp.IdCamion = int.Parse(dtcamion.Rows[i]["idcamion"].ToString());
                camTemp.Descripcion = dtcamion.Rows[i]["descripcion"].ToString();
                camTemp.Placa = dtcamion.Rows[i]["placa"].ToString();
                camTemp.Marca = dtcamion.Rows[i]["marca"].ToString();
                camTemp.Modelo = dtcamion.Rows[i]["modelo"].ToString();
                lstCamion.Add(camTemp);
            }
            return lstCamion;
        }

        public Camion obtenerCamion(int IdCamion)
        {
            Camion camion;
            DataTable dtcamion = new DataTable();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idcamion", IdCamion));
            dtcamion = BaseHelper.ejecutarSelect("spcamionConsultarPorID", CommandType.StoredProcedure, parametros);
            if (dtcamion.Rows.Count > 0)
            {
                camion = new Camion();
                camion.IdCamion = int.Parse(dtcamion.Rows[0]["idcamion"].ToString());
                camion.Descripcion = dtcamion.Rows[0]["descripcion"].ToString();
                camion.Placa = dtcamion.Rows[0]["placa"].ToString();
                camion.Marca = dtcamion.Rows[0]["marca"].ToString();
                camion.Modelo = dtcamion.Rows[0]["modelo"].ToString();
                return camion;
            }
            else
            {

                return null;
            }
        }

        public void InsertarCamion(Camion datosAInsertar)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idcamion",datosAInsertar.IdCamion));
            parametros.Add(new SqlParameter("@descripcion", datosAInsertar.Descripcion));
            parametros.Add(new SqlParameter("@placa",datosAInsertar.Placa));
            parametros.Add(new SqlParameter("@marca", datosAInsertar.Marca));
            parametros.Add(new SqlParameter("@modelo", datosAInsertar.Modelo));
            BaseHelper.ejecutarSentencia("spaddcamion", CommandType.StoredProcedure, parametros);
        }

        public void EliminarCamion(int IdCamion)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idcamion",IdCamion));
            BaseHelper.ejecutarSentencia("spdeletecamion", CommandType.StoredProcedure, parametros);
        }

        public void ActualizarCamion(Camion datosNuevos)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idcamion", datosNuevos.IdCamion));
            parametros.Add(new SqlParameter("@descripcion", datosNuevos.Descripcion));
            parametros.Add(new SqlParameter("@placa", datosNuevos.Placa));
            parametros.Add(new SqlParameter("@marca", datosNuevos.Marca));
            parametros.Add(new SqlParameter("@modelo", datosNuevos.Modelo));
            BaseHelper.ejecutarSentencia("spupdatecamion", CommandType.StoredProcedure, parametros);
        }
    }
}