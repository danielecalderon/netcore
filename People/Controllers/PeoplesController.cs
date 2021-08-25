using System.Collections.Generic;
using People.Data;
using People.Models;
using Microsoft.AspNetCore.Mvc;

namespace People.Controllers
{
    //api/commands
    //[Route("api/[controller]")]
    [Route("api/controller")]
    [ApiController]
    public class PeoplesController : ControllerBase
    {
      private readonly MockPeopleRepo _repository = new MockPeopleRepo();
      //GET api/commands/{id}  
      [HttpGet]
      public ActionResult <IEnumerable<Command>> GetAllCommands()     
      {
           var commandItems = _repository.GetAppCommands();
           return Ok(commandItems);
      }

      //GET api/commands/{id}
      [HttpGet("{id}")]
      public ActionResult <Command> GetCommandById(int id)
      {
          var commandItems = _repository.GetCommandById(id);
          return Ok(commandItems);
      }

    }

}