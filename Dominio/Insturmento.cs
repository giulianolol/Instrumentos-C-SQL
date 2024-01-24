using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Insturmento
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int CantidadCuerdas { get; set; }
        public string UrlImagenEjemplo { get; set; }
        public string Color { get; set; }
        public int IdTipo { get; set; }
        public int IdMadera { get; set; }
        public string Precio { get; set; }
    }
}
