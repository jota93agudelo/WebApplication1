using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.DB
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public bool Activado { get; set; }
    }
}
