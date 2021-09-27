using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.BL
{
    public class ProductosBL
    {
        public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Play Station 4";
            producto1.Categoria = "Consolas";
            producto1.Precio = 7000;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "DOOM ETERNAL";
            producto2.Categoria = "Juegos";
            producto2.Precio = 2000;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Play Station 3";
            producto3.Categoria = "Consolas";
            producto3.Precio = 3500;

            var producto4 = new Producto();
            producto4.Id = 4;
            producto4.Descripcion = "Control PS4";
            producto4.Categoria = "Accesorios";
            producto4.Precio = 900;

            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
            listadeProductos.Add(producto4);


            return listadeProductos;
        }
    }
}
