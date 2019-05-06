using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.DB
{
    public class Carro
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public bool Todoterreno {get;set;}
        public string Placa { get; set; }
    }
}
