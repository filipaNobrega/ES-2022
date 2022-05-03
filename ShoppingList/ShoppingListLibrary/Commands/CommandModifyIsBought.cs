using ShoppingListLibrary.Models;
using ShoppingListLibrary.Patterns;

namespace ShoppingListLibrary.Commands
{
    public class CommandModifyIsBought : ICommand
    {
        public CommandModifyIsBought(ListItem item, bool newValue)
        {
            Item = item;
            NewValue = newValue;
        }

        public ListItem Item { get; }
        public bool NewValue { get; private set; }

        public void Execute()
        {
            bool isBought = Item.IsBought;
            Item.IsBought = NewValue;
            NewValue = isBought;
        }

        public void Redo() => Execute();
        public void Undo() => Execute();
    }
}
