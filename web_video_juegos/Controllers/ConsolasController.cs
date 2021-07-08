using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using api_video_juegos.Models;

namespace web_video_juegos.Controllers
{
    public class ConsolasController : Controller
    {
        video_juegos_bd bd = new video_juegos_bd();
        // GET: Consolas
        public ActionResult Index()
        {
            return View(bd.consolas);
        }

        // GET: Consolas/Details/5
        public ActionResult Details(int id)
        {
           consola consola_buscado = bd.consolas.Find(id);
            return View(consola_buscado);
        }

        // GET: Consolas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Consolas/Create
        [HttpPost]
        public ActionResult Create(consola new_consola)
        {
            try
            {
                bd.consolas.Add(new_consola);
                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Consolas/Edit/5
        public ActionResult Edit(int id)
        {
            consola consola_buscado = bd.consolas.Find(id);
            return View(consola_buscado);
        }

        // POST: Consolas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, consola video_consola)
        {
            try
            {
                //Obtener el mando que se quiere modificar
                consola consola_buscado = bd.consolas.Find(id);
                //Aplicar cambios sobre sus propiedades
                consola_buscado.marca = video_consola.marca;
                consola_buscado.modelo = video_consola.modelo;
                consola_buscado.nueva = video_consola.nueva;
                consola_buscado.precio = video_consola.precio;
                consola_buscado.stock = video_consola.stock;

                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Consolas/Delete/5
        public ActionResult Delete(int id)
        {
            consola consola_buscado = bd.consolas.Find(id);
            return View(consola_buscado);
        }

        // POST: Consolas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                consola consola_buscado = bd.consolas.Find(id);
                bd.consolas.Remove(consola_buscado);
                bd.SaveChanges();
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
