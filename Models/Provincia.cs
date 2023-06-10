using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica_Mercantil.Models
{
    public class Provincia
    {
        public int ProvinciaID { get; set; }
        public string NombreProvincia { get; set; }
        public List<Distrito> DistritoList { get; set; }
        public int IdDepartamento { get; set; }
        public Departamento Departamento { get; set; }
    }
}
