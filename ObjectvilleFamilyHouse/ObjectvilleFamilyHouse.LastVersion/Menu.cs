using System.Text;

namespace ObjectvilleFamilyHouse.LastVersion
{
    public class Menu : MenuComponent
    {
        public Menu(string name, string description) : base(name, description)
        {
        }

        public override string ToString()
        {
            var strBuilder = new StringBuilder();
            strBuilder.AppendLine($"{Name} - {Description}");
            
            foreach (var child in Children)
            {
                strBuilder.AppendLine(child.ToString());
            }

            //using var enumerator = Children.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    var component = (MenuComponent)enumerator.Current;
            //    strBuilder.AppendLine(component.ToString());
            //}

            return strBuilder.ToString();
        }
    }
}