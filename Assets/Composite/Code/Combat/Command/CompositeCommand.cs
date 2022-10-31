using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Command;

namespace Combat.Command
{
    public class CompositeCommand : ICommand
    {
        private List<ICommand> commands;

        public CompositeCommand()
        {
            commands = new List<ICommand>();
        }

        public void AddCommand(ICommand command)
        {
            commands.Add(command);
        }
        
        public async Task Execute()
        {
            var tasks = new List<Task>();
            foreach (var command in commands)
            {
                tasks.Add(command.Execute());
            }

            await Task.WhenAll(tasks);
        }
    }
}
