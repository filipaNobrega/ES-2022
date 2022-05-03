using ShoppingListLibrary.Models;
using ShoppingListLibrary.Patterns;

namespace ShoppingListLibrary.Commands
{
    public class CommandModifyTitle : ICommand
    {
        public CommandModifyTitle(ListItem item, string newTitle)
        {
            Item = item;
            NewTitle = newTitle;
        }
        public ListItem Item { get; }
        public string NewTitle { get; private set; }

        public void Execute()
        {
            var title = Item.Title;
            Item.Title = NewTitle;
            NewTitle = title;
        }

        public void Redo() => Execute();
        public void Undo() => Execute();
    }
}
