using System.Collections.Generic;
using TodoList.Models;

namespace TodoList.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}