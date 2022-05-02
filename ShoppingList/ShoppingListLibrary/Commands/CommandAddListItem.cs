using ShoppingListLibrary.Models;
using ShoppingListLibrary.Patterns;

namespace ShoppingListLibrary.Commands
{
    public class CommandAddListItem : ICommand
    {
        public CommandAddListItem(List<ListItem> items, ListItem newItem)
        {
            Items = items;
            NewItem = newItem ?? throw new ArgumentNullException(nameof(newItem));
        }

        public List<ListItem> Items { get; }
        public ListItem NewItem { get; }

        public void Execute()
        {
            Items.Add(NewItem);
        }

        public void Redo()
        {
            Execute();
        }

        public void Undo()
        {
            Items.Remove(NewItem);
        }
    }
}
