using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        // public MockCommanderRepo(Parameters)
        // {

        // }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boild an egg", Line = "boild water", Platform = "Some text" },
                new Command { Id = 1, HowTo = "Huevos a la mexicana", Line = "mezclar huevos con jitomate, cebolla y picante", Platform = "Some text" },
                new Command { Id = 2, HowTo = "huevos con jamon", Line = "mezclar huevos con jamon", Platform = "Some text" },
                new Command { Id = 3, HowTo = "huevos con salchicha", Line = "mezclar huevos con salchichas", Platform = "Some text" }
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boild an egg", Line = "boild water", Platform = "Some text" };
        }
    }
}