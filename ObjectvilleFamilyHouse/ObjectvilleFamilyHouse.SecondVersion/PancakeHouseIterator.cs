using System.Collections;

namespace ObjectvilleFamilyHouse.SecondVersion
{
    // Using Iterator pattern to encapsulate the way we iterate through a collection of objects
    public class PancakeHouseIterator : IEnumerator
    {
        private readonly ArrayList _menuItems;
        private int _position = -1;

        public PancakeHouseIterator(ArrayList menuItems)
        {
            _menuItems = menuItems;
        }

        public bool MoveNext()
        {
            _position++;
            return _position < _menuItems.Count;
        }

        public void Reset()
        {
            _position = -1;
        }

        public object Current
        {
            get
            {
                return _menuItems[_position];
            }
        }
    }
}