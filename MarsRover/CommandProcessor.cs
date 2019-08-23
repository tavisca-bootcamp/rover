using MarsRover.Commands;
using System.Collections.Generic;
using System;

namespace MarsRover
{
    public class CommandProcessor
    {
        private string _commandString;

        private Dictionary<string, ICommand> _commandMapping = new Dictionary<string, ICommand>()
        {
            {"L", new RotateLeftCommand() },
            {"R", new RotateRightCommand() },
            {"M", new MoveCommand() },
        };

        public CommandProcessor(string commandString)
        {
            _commandString = commandString;
        }

        public List<ICommand> ToCommands()
        {
            if (IsNullOrEmpty(_commandString)) return new List<ICommand>();
            return BuildCommandList();
        }

        private List<ICommand> BuildCommandList()
        {
            List<ICommand> commandsList = new List<ICommand>();

            foreach(var command in _commandString)
            {
                ICommand mappedCommand = LookUpCommand(command.ToString().ToUpper());
                commandsList.Add(mappedCommand);
            }

            return commandsList;
        }

        private ICommand LookUpCommand(string commandName)
        {
            _commandMapping.TryGetValue(commandName, out ICommand command);
            return command;
        }

        private bool IsNullOrEmpty(string commandString)
        {
            return (_commandString == null || _commandString.Length == 0);
        }
    }

}
