using System.Collections.Generic;

namespace PracticaPOO.Clases
{
    public class FlotillaCamiones
    {
        List<Camión> flotilla;

        public FlotillaCamiones()
        {
            flotilla = new List<Camión>();
        }

        public void AdquirirCamión()
        {
            flotilla.Add(new Camión());
        }
    }
}
