namespace ObjectvilleFamilyHouse.LastVersion
{
    public interface IMenuComponent
    {
        public string Name { get; }
        public string Description { get; }
        void Add(IMenuComponent child);
        void Remove(IMenuComponent child);
        IMenuComponent GetChild(int index);
    }
}