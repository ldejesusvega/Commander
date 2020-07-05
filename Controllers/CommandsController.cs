using System.Collections.Generic;
using AutoMapper;
using Commander.Data;
using Commander.Dtos;
using Commander.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    /// api/commands
    [Route("api/commands")]  /// This decoration is fixed as api/commands even if the controller class name changes 
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;
        private readonly IMapper _mapper;

        public CommandsController(ICommanderRepo repository, IMapper mapper)
        {
            this._mapper = mapper;
            _repository = repository;
        }
        // private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        /// get api/commands
        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands()
        {
            var commands = _repository.GetAllCommands();

            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commands));
        }

        /// get api/commands/5
        /// get api/commands/{id}
        [HttpGet("{id}", Name = "GetCommandById")]
        public ActionResult<CommandReadDto> GetCommandById(int id)
        {
            var command = _repository.GetCommandById(id);

            if (command != null)
            {
                return Ok(_mapper.Map<CommandReadDto>(command));
            }
            return NotFound();

        }

        // POST api/command
        [HttpPost]
        public ActionResult<CommandReadDto> CreateCommand(CommandCreateDto commandCreateDto)
        {
            var commandModel = _mapper.Map<CommandCreateDto, Command>(commandCreateDto);
            _repository.CreateCommand(commandModel);
            _repository.SaveChanges();
            // return Ok(_mapper.Map<Command, CommandCreateDto>(commandModel));
            var commandReadDto = _mapper.Map<CommandReadDto>(commandModel);
            return CreatedAtRoute(nameof(GetCommandById), new { Id = commandReadDto.Id }, commandCreateDto);
        }

        /// PUT api/commands/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateCommand(int id, CommandUpdateDto commandUpdateDto)
        {
            var commandModelFromRepo = _repository.GetCommandById(id);
            if (commandModelFromRepo == null)
                return NotFound();

            _mapper.Map(commandUpdateDto, commandModelFromRepo);
            _repository.UpdateCommand(commandModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

        /// PATCH api/commands/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialCommandUpdate(int id, JsonPatchDocument<CommandUpdateDto> patchDocument)
        {
            var commandModelFromRepo = _repository.GetCommandById(id);
            if (commandModelFromRepo == null)
                return NotFound();

            var commandToPatch = _mapper.Map<CommandUpdateDto>(commandModelFromRepo);
            patchDocument.ApplyTo(commandToPatch, ModelState);
            if (!TryValidateModel(commandToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(commandToPatch, commandModelFromRepo);
            _repository.UpdateCommand(commandModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }


    }
}