using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ModelKinhDoanhApi.Controller
{
    public class HomeController 
    {
        [Produces("application/json")]
        [Route("api/kinhdoanh")]
        public class KinhDoanhController : ControllerBase
        {
            [HttpPost]
            [Route("kinhdoanhs")]
            [AllowAnonymous]
            public IActionResult KinhDoanh()
            {
                return Ok();
            }


        }
    }
}
