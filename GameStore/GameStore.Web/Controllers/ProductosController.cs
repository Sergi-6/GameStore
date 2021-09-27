using GameStore.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStore.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto1 = new ProductoModel();
            producto1.Id = 1;
            producto1.Descripcion = "Play Station 4";
            producto1.Categoria = "Consolas";
            producto1.Precio = 7000;

            var producto2 = new ProductoModel();
            producto2.Id = 2;
            producto2.Descripcion = "DOOM ETERNAL";
            producto2.Categoria = "Juegos";
            producto2.Precio = 2000;

            var producto3 = new ProductoModel();
            producto3.Id = 3;
            producto3.Descripcion = "Play Station 3";
            producto3.Categoria = "Consolas";
            producto3.Precio = 3500;

            var producto4 = new ProductoModel();
            producto4.Id = 4;
            producto4.Descripcion = "Control PS4";
            producto4.Categoria = "Accesorios";
            producto4.Precio = 900;

            var listadeProductos = new List<ProductoModel>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
            listadeProductos.Add(producto4);


            return View(listadeProductos);
        }
    }
}