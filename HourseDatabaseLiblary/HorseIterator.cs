using System.Collections;

namespace HourseDatabaseLiblary
{
    public class HorseCollection : IEnumerable
    {
        private readonly Hashtable Collection;

        public HorseCollection()
        {
            Collection = new Hashtable();
        }

        public Horse this[string name]
        {
            get {
                return (Horse) Collection[name];
            }
            set {
                this.Add(name, value);
            }
        }

        public void Add(string name, Horse value)
        {
            Collection.Add(name, value);
        }

        public void Add(Horse hourse)
        {
            Collection.Add(hourse.Name, hourse);
        }

        public void Remove(Horse hourse)
        {
            Collection.Remove(hourse.Name);
        }

        public void Remove(string name)
        {
            Collection.Remove(name);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Horse hourse in Collection)
            {
                yield return hourse;
            }
        }
    }
}
