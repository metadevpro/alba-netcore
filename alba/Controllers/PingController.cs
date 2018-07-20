using alba.Cal;
using Microsoft.AspNetCore.Mvc;
using Metadev.Oas3.Attributes;

namespace alba.Controllers
{
    [Route("api/ping")]
    public class PingController: Controller
    {
        //[HttpGet]
        //public PongResponse Get()
        //{
        //    return PongResponse.Response();
        //}
        [HttpGet]
        [Operation("ping")]
        [Description("ping operation for load-balancers.")]
        [Response(200, "Ping reponse", typeof(PongResponse))]
        public IActionResult Get()
        {
            return new OkObjectResult(PongResponse.Response());
        }
    }
}
