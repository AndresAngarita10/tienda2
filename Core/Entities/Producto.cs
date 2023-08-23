using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class Producto
    {
        public int Id { get; set; }
        public string CodInterno { get; set; }
        public string Nombre { get; set; }
        public int StockMin { get; set; }
        public int StockMax { get; set; }
        public int Stock { get; set; }
        public double ValorVta { get; set; }
        public ICollection<Persona> Personas { get; set; } = new HashSet<Persona>();
        public ICollection<ProductoPersona> ProductosPersonas{ get; set; }
    }
