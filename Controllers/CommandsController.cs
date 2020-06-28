using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    /// api/commands
    [Route("api/commands")]  /// This decoration is fixed as api/commands even if the controller class name changes 
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;

        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
        }
        // private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        /// get api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commands = _repository.GetAllCommands();
            return Ok(commands);
        }

        /// get api/commands/5
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var command = _repository.GetCommandById(id);
            return Ok(command);
        }

    }
}