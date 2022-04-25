using System.Collections;

namespace ObjectvilleFamilyHouse.SecondVersion
{
    // Using Iterator pattern to encapsulate the way we iterate through a collection of objects
    class DinerMenuIterator : IEnumerator
    {
        private readonly MenuItem[] _menuItems;
        private int _position = -1;

        public DinerMenuIterator(MenuItem[] menuItems)
        {
            _menuItems = menuItems;
        }

        public bool MoveNext()
        {
            _position++;
            return _position < _menuItems.Length;
        }

        public void Reset()
        {
            _position = -1;
        }

        public object Current
        {
            get
            {
                MenuItem menuItem = _menuItems[_position];
                return menuItem;
            }
        }
    }
}
