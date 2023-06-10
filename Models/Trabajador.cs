using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace Practica_Mercantil.Models
{
    public class Trabajador
    {
        public int TrabajadorID { get; set; }
        public string Tipo_documento { get; set; }
        public string Nro_documento { get; set; }
        public string Nombres { get; set; }
        public string Sexo { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }

        // public int DistritoId { get; set; }
        // public Distrito Distrito { get; set; }

    //    public override string ToString () => JsonSerializer.Serialize<Trabajador>(this);

    //    public Trabajador ()
    //    {
    //        Tipo_documento= string.Empty;
    //        Nro_documento= string.Empty;
    //        Nombres= string.Empty;
    //        Sexo= string.Empty;
    //        Departamento= string.Empty;
    //        Provincia= string.Empty;
    //        //DistritoId= 0;
    //    }
    }
}
