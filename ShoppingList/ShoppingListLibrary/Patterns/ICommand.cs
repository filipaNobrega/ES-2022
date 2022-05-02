namespace ShoppingListLibrary.Patterns
{
    public interface ICommand
    {
        void Execute();
        void Undo();
        void Redo();
    }
}
