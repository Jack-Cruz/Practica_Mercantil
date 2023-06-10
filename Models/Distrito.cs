using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica_Mercantil.Models
{
    public class Distrito
    {
        public int DistritoID { get; set; }
        public string NombreDistrito { get; set; }
        public List<Trabajador> TrabajadorList { get; set; }

        public int IdProvincia { get; set; }
        public Provincia Provincia { get; set; }
        //public Distrito() 
        //{
        //    NombreDistrito = "";
        //    TrabajadorList = new List<Trabajador>();
        //    Provincia = new Provincia();
        //}
        
    }
}
