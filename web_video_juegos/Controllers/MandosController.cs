using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using api_video_juegos.Models;

namespace web_video_juegos.Controllers
{
    public class MandosController : Controller
    {
        video_juegos_bd bd = new video_juegos_bd();
        // GET: Mandos
        public ActionResult Index()
        {
            //Al llamar a la vista debemos entregar los mandos
            return View(bd.mandos);
        }

        // GET: Mandos/Details/5
        public ActionResult Details(int id)
        {
            mando mando_buscado = bd.mandos.Find(id);
            return View(mando_buscado);
        }

        // GET: Mandos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mandos/Create
        [HttpPost]
        public ActionResult Create(mando new_mando)
        {
            try
            {
                // TODO: Add insert logic here
                bd.mandos.Add(new_mando);
                bd.SaveChanges();
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mandos/Edit/5
        public ActionResult Edit(int id)
        {
            mando mando_buscado = bd.mandos.Find(id);
            return View(mando_buscado);
        }

        // POST: Mandos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, mando control)
        {
            try
            {
                //Obtener el mando que se quiere modificar
                mando mando_buscado = bd.mandos.Find(id);
                //Aplicar cambios sobre sus propiedades
                mando_buscado.marca = control.marca;
                mando_buscado.modelo = control.modelo;
                mando_buscado.precio = control.precio;
                mando_buscado.stock = control.stock;

                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mandos/Delete/5
        public ActionResult Delete(int id)
        {
            mando mando_buscado = bd.mandos.Find(id);
            return View(mando_buscado);
        }

        // POST: Mandos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                mando mando_buscado = bd.mandos.Find(id);
                bd.mandos.Remove(mando_buscado);
                bd.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
