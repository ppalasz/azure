using Microsoft.AspNetCore.Mvc;

namespace WebCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TriggerController : ControllerBase
    {

        // GET api/trigger/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "get "+ id;
        }

       
    }
}
