using Practica_Mercantil.Models;
using System.Text.Json;

namespace Practica_Mercantil.Services
{
    public class JsonFileWorkerService
    {
        public IWebHostEnvironment WebHostEnvironment { get; }
        public JsonFileWorkerService(IWebHostEnvironment webHostEnvironment) 
        {
            WebHostEnvironment = webHostEnvironment;    
        }

        private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "workers.json");
        public IEnumerable<Trabajador> GetWorkers()
        {
            using var jsonFileReader = File.OpenText(JsonFileName);
            Trabajador[]? workers = JsonSerializer.Deserialize<Trabajador[]>(jsonFileReader.ReadToEnd(),
                            new JsonSerializerOptions
                            {
                                PropertyNameCaseInsensitive = true
                            });
            return workers;
        }
    }

}
