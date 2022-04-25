using ObjectvilleFamilyHouse.LastVersion;
using System.Collections.Generic;

namespace ObjectvilleFamilyHouse.LastVersion
{
    public abstract class MenuComponent : IMenuComponent
    {
        protected IList<IMenuComponent> Children { get; } = new List<IMenuComponent>();

        protected MenuComponent(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; }
        public string Description { get; }

        public void Add(IMenuComponent child)
        {
            if (Children.Contains(child))
            {
                return;
            }

            Children.Add(child);
        }

        public void Remove(IMenuComponent child)
        {
            if (!Children.Contains(child))
            {
                return;
            }

            Children.Remove(child);
        }

        public IMenuComponent GetChild(int index)
        {
            return Children[index];
        }
    }
}