using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCamion.Models
{
    public class Camion
    {
        public int IdCamion { get; set; }
        public string Descripcion { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
    }
}