using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class DatosUsuario
    {
        public string Izena { get; set; }
        public string Abizena { get; set; }
        public string Telefonoa { get; set; }
        public string Generoa { get; set; }
        public string Prefijoa { get; set; }

        public DatosUsuario() { }

        public DatosUsuario(string izena, string abizena, string telefonoa, string generoa, string prefijoa)
        {
            Izena = izena;
            Abizena = abizena;
            Telefonoa = telefonoa;
            Generoa = generoa;
            Prefijoa = prefijoa;
        }



        // Lista que almacenará todos los usuarios
        public static List<DatosUsuario> IzenaTaula = new List<DatosUsuario>();

        // Método para añadir un nuevo registro
        public void GehituErregistroa()
        {
            IzenaTaula.Add(this);
        }

        public static List<DatosUsuario> ikusi()
        {
            return IzenaTaula;
        }

        public static List<DatosUsuario> bilatu(string telef)
        {
            return IzenaTaula.Where(k => k.Telefonoa == telef).ToList();
        }
    }
}
