using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class Pais
    {
        public int Id { get; set; }
        public string NombrePais { get; set;}

        
        public ICollection<Estado> Estados { get; set; }
    }
