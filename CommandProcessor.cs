using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interation7And8
{
    public class CommandProcessor
    {
        private List<Command> _commandsList;

        public List<Command> CommandsList { get => _commandsList; set => _commandsList = value; }

        public CommandProcessor()
        {
            CommandsList = new List<Command>();
        }
        public string Execute (Player player, string inputText)
        {
            string[] words = inputText.Split(' ');
            if (words.Length < 1)
                return " Not enough information";
            foreach (Command command in CommandsList)
            {
                if (command.AreYou(words[0]))
                {
                    return command.Execute(player, words);
                }
            }
            return " This is an invalid input. Please try again to enjoy Swin Adventure";

        }
    }
}
