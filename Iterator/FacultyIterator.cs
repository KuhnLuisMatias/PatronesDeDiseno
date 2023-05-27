using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class FacultyIterator : IEnumerator
    {
        private ArrayList _faculties;
        private int _current = -1;
        private StudentIterator _studentIterator;

        public FacultyIterator(ArrayList faculties)
        {
            _faculties = faculties;
        }

        public bool MoveNext()
        {
            if (_studentIterator != null && _studentIterator.MoveNext())
                return true;

            if (++_current < _faculties.Count)
            {
                Faculty faculty = (Faculty)_faculties[_current];
                _studentIterator = (StudentIterator)faculty.GetEnumerator();
                return MoveNext();
            }

            return false;
        }

        public void Reset()
        {
            _current = -1;
            _studentIterator = null;
        }

        public object Current
        {
            get { return _studentIterator.Current; }
        }
    }
}
