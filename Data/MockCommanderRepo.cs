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
                new Command { Id = 2, HowTo = "Cortar Pan", Line = "tomar la  pieza de pan a cortar", Platform = "Some text" },
                new Command { Id = 3, HowTo = "aplicar jelly", Line = "poner jelly sobre el pan", Platform = "Some text" }
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boild an egg", Line = "boild water", Platform = "Some text" };
        }
    }
}