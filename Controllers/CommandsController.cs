using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    /// api/commands
    [Route("api/commands")]  /// This decoration is fixed as api/commands even if the controller class name changes 
    [ApiController]
    public class CommandsController : ControllerBase
    {

    }
}