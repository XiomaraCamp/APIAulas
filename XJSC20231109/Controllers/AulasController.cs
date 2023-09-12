using Microsoft.AspNetCore.Mvc;
using XJSC20231109.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace XJSC20231109.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AulasController : ControllerBase
    {
        static List<Aulas> aulas = new List<Aulas>()
        { 
            new Aulas() { Id = 1,aulas = "Matematicas"},
           new Aulas() { Id = 1,aulas = "Ciencias"},
           new Aulas() { Id = 1,aulas = "Informatica"},
        };

        [HttpGet]
        public IEnumerable<Aulas> Get()
        {
            return aulas;
        }

    }
}
