using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class StudentIterator : IEnumerator
    {
        private ArrayList _students;
        private int _current = -1;

        public StudentIterator(ArrayList students)
        {
            _students = students;
        }

        public bool MoveNext()
        {
            _current++;
            return (_current < _students.Count);
        }

        public void Reset()
        {
            _current = -1;
        }

        public object Current
        {
            get
            {
                if (_current >= 0 && _current < _students.Count)
                    return _students[_current];
                else
                    return null;
            }
        }
    }
}
