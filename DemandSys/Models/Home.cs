using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemandSys.Models
{
    public class Home
    {
        public int? Codigo { get; set; }
        public string Tipo { get; set; }
        public string Link { get; set; }
        public string Titulo { get; set; }

        public Home()
        { }

        public Home(int codigo, string tipo, string link, string titulo)
        {
            Codigo = codigo;
            Tipo = tipo;
            Link = link;
            Titulo = titulo;
        }
    }
}
