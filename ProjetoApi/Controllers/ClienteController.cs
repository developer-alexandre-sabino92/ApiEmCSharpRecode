using Microsoft.AspNetCore.Mvc;

namespace ProjetoApi.Controllers
{   
    [ApiController]
    [Route("api/[controller]")] 


    public class ClienteController : ControllerBase
    {   

        [HttpGet]
        public string Hello(){
            return "Oi";
        }
    }
}