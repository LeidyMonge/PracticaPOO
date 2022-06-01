using PracticaPOO.Enums;
using System.Collections.Generic;

namespace PracticaPOO.Clases
{
    public class Transporte
    {
        public  TipoTransporte Tipo{ get; set; }
        public string Duracion { get; set; }
        Dictionary<int,Producto> Productos { get; set; }



    }
}
