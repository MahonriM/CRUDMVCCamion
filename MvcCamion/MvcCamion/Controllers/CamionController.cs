using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCamion.Models;

namespace MvcCamion.Controllers
{
    public class CamionController : Controller
    {
        //
        // GET: /Camion/
        ICamion camionRepositorio = new CamionRepositorio(); 
        public ActionResult Index()
        {
            return View(camionRepositorio.obtenerCamiones());
        }
        public ActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Camion DatosAinsertar)
        {
            camionRepositorio.InsertarCamion(DatosAinsertar);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {

            return View(camionRepositorio.obtenerCamion(id));
        }
        public ActionResult Delete(int id)
        {

            return View(camionRepositorio.obtenerCamion(id));
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection frmdata)
        {
            camionRepositorio.EliminarCamion(id);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {

            return View(camionRepositorio.obtenerCamion(id));
        }
        [HttpPost]
        public ActionResult Edit(int id, Camion emp)
        {
            emp.IdCamion = id;
            camionRepositorio.ActualizarCamion(emp);
            return RedirectToAction("Index");
        }

    }
}
