using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCamion.Models
{
    public interface ICamion
    {
        List<Camion> obtenerCamiones();
        Camion obtenerCamion(int IdCamion);
        void InsertarCamion(Camion datosAInsertar);
        void EliminarCamion(int IdCamion);
        void ActualizarCamion(Camion datosNuevos);
    }
}