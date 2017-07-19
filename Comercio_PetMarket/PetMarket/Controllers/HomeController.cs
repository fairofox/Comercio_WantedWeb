using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetMarket.Controllers
{
    public class HomeController : Controller
    {
        private Models.PetsDataEntities bd = new Models.PetsDataEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Buscar(String id="")
        {   
            //Logica para el acceso a la base de datos
            var productos = bd.Producto.Where(x => x.Descripcion.Contains(id)).ToList();
            //Lista de productos
            ViewBag.clave = id;
            return View(productos);
        }
    }
}