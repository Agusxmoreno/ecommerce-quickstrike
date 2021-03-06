using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public int ID { get; set; }
        public Categoria Categoria { get; set; }
        public Marca Marca { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string UrlImagen { get; set; }
        public bool Estado { get; set; }
    }
}
