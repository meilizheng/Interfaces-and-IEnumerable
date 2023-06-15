using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_IEnumerable
{
    public class Classroster : IEnumerable
    {
        List<string> _names;

        public Classroster()
        {
            _names = new List<string>();
            _names.Add("Emma");
            _names.Add("Liam");
            _names.Add("Olivia");
            _names.Add("Noah");
            _names.Add("Ava");
            _names.Add("Isabella");
            _names.Add("Sophia");
            _names.Add("Mia");
            _names.Add("Jackson");
            _names.Add("Aiden");
            _names.Add("Lucas");
            _names.Add("Caden");
            _names.Add("Charlotte");
            _names.Add("Amelia");
            _names.Add("Harper");
            _names.Add("Evelyn");
            _names.Add("Abigail");
            _names.Add("Benjamin");
            _names.Add("Henry");
            _names.Add("Samuel");
        }

        public List<string> Names
        {
            get { return _names; }
        }

        public IEnumerator GetEnumerator()
        {
            return new ClassrosterEnumerator(_names);
        }

        private class ClassrosterEnumerator : IEnumerator
        {
            List<string> _ClassRoster;
            int index = -1;

            public ClassrosterEnumerator(List<string> classRoster)
            {
                _ClassRoster = classRoster;
            }

            public object Current => _ClassRoster[index];


            bool IEnumerator.MoveNext()
            {
                index++;

                if (index >= _ClassRoster.Count)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            void IEnumerator.Reset()
            {
                index = -1;
            }
        }
    }
}
