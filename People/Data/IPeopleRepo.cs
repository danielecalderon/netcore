using System.Collections.Generic;
using People.Models;

namespace People.Data
{
    public interface IPeopleRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);

    }
}