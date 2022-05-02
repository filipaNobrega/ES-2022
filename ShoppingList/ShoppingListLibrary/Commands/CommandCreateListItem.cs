using ShoppingListLibrary.Models;
using ShoppingListLibrary.Patterns;

namespace ShoppingListLibrary.Commands
{
    public class CommandCreateListItem : ICommand
    {
        public CommandCreateListItem(string title)
        {
            Title = title;
        }

        public string Title { get; }
        public ListItem? Item { get; private set; }

        public void Execute()
        {
            Item = new ListItem { Title = Title, IsBought = false };
        }

        public void Redo()
        {
            Execute();
        }

        public void Undo()
        {
            Item = null;
        }
    }
}
