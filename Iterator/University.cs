using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class University : IEnumerable
    {
        public string Name { get; set; }
        public ArrayList Faculties = new ArrayList();

        public IEnumerator GetEnumerator()
        {
            return new FacultyIterator(Faculties);
        }
    }
}
