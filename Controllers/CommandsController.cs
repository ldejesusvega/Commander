using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    /// api/commands
    [Route("api/[controller]")]  /// This decoration will build the route based on controller name e.g. api/commands 
    [ApiController]
    public class CommandsController : ControllerBase
    {

    }
}