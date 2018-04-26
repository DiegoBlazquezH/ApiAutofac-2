using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploApi.Common.Logic
{
    public class Usuario : IModel
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public override string ToString()
        {
            return string.Concat(ID, ",", Nombre, ",", Apellidos);
        }
    }
}
