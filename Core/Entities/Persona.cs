using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class Persona : BaseEntity
    {
        public string IdPersona { get; set; }
        public string NombrePersona { get; set;}
        public DateOnly FechaNacimiento { get; set; }
        public int IdTipoPersonaFk { get; set; }
        public TipoPersona TipoPersona { get; set; }
        public int IdRegionFk { get; set; }
        public Region Region { get; set; }
        public ICollection<Producto> Productos { get; set; } = new HashSet<Producto>();
        public ICollection<ProductoPersona> ProductosPersonas{ get; set; }
    }
