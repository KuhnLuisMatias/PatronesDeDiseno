using Composite.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Model
{
    public class CompositeClass : IComponent
    {
        public string Name { get; set; }
        
        List<IComponent> components = new List<IComponent>();
        public CompositeClass(string name)
        {
            this.Name = name;
        }
        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }
        public void DisplayPrice()
        {
            foreach (var item in components)
            {
                item.DisplayPrice();
            }
        }
    }
}
