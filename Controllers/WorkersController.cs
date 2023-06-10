using Microsoft.AspNetCore.Mvc;
using Practica_Mercantil.Models;
using Practica_Mercantil.Services;

namespace Practica_Mercantil.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WorkersController : ControllerBase
    {
        public JsonFileWorkerService ProductService { get; }

        public WorkersController(JsonFileWorkerService productService) {
            ProductService = productService;
        }

        [HttpGet]
        public IEnumerable<Trabajador> Get()
        {
            return ProductService.GetWorkers();
        }
    }
}
