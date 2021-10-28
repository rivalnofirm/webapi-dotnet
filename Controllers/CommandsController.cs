using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoList.Data;
using TodoList.Models;

namespace TodoList.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAppCommands();

            return Ok(commandItems);
        }

        [HttpGet("{id}")]
        public ActionResult <IEnumerable<Command>> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);
        }

    }
}