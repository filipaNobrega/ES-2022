using ShoppingListLibrary.Models;
using ShoppingListLibrary.Patterns;

namespace ShoppingListLibrary.Commands
{
    public class CommandDeleteListItem : ICommand
    {
        public CommandDeleteListItem(List<ListItem> items, ListItem item)
        {
            Items = items;
            Item = item;
        }

        public List<ListItem> Items { get; }
        public ListItem Item { get; }

        public void Execute()
        {
            Items.Remove(Item);
        }

        public void Redo()
        {
            Execute();
        }

        public void Undo()
        {
            Items.Add(Item);
        }
    }
}
