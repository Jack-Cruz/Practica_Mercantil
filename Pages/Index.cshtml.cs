using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practica_Mercantil.Models;
using Practica_Mercantil.Services;

namespace Practica_Mercantil.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileWorkerService WorkerService;
        public IEnumerable<Trabajador> Workers { get; private set; }

        public IndexModel (ILogger<IndexModel> logger,
            JsonFileWorkerService workerService)
        {
            _logger = logger;
            WorkerService= workerService;
        }

        public void OnGet ()
        {
            Workers = WorkerService.GetWorkers();
        }
    }
}