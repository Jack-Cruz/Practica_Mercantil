using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica_Mercantil.Models
{
    public class Departamento
    {
        public int DepartamentoID { get; set; }
        public string NombreDepartamento { get; set;}
        public ICollection<Provincia> ProvinciaList { get; set;}
    }
}
