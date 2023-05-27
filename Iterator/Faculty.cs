using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Faculty : IEnumerable
    {
        public string Name { get; set; }
        public ArrayList Students = new ArrayList();

        public IEnumerator GetEnumerator()
        {
            return new StudentIterator(Students);
        }
    }
}
