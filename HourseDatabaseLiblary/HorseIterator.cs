using System;
using System.Diagnostics;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace HourseDatabaseLiblary
{
    public class HorseIterator : IEnumerable
    {
        private List<Horse> collection = new List<Horse>();

        public void Add(Horse hourse)
        {
            collection.Add(hourse);
        }

        public bool Remove(Horse hourse)
        {
            return collection.Remove(hourse);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Horse hourse in collection)
            {
                yield return hourse;
            }
        }
    }
}
