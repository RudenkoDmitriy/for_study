using System.Collections.Generic;
using System.Collections;

namespace _2
{
    public class Set<T> : IEnumerable<T>
    {
        /// <summary>
        /// Add element in set.
        /// </summary>
        /// <param name="value"></param>
        public void Add(T value)
        {
            if (this.Find(value))
            {
                return;
            }
            list.Insert(index, value);
            index++;
        }

        /// <summary>
        /// Find element in set.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Find(T value)
        {
            foreach (T x in this.list)
            {
                if (value.Equals(x))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Delete element in set.
        /// </summary>
        /// <param name="value"></param>
        public void Remove(T value)
        {
            if (!this.Find(value))
            {
                throw new DeleteNotExistElementException();
            }
            this.list.Remove(value);
        }

        /// <summary>
        /// Union of two sets.
        /// </summary>
        /// <param name="set"></param>
        /// <returns></returns>
        public Set<T> Union(Set<T> set)
        {
            var result = new Set<T>();
            foreach (T x in set)
            {
                result.Add(x);
            }
            foreach (T x in this.list)
            {
                if (!result.Find(x))
                {
                    result.Add(x);
                }
            }
            return result;
        }

        /// <summary>
        /// Intersection of two sets.
        /// </summary>
        /// <param name="set"></param>
        /// <returns></returns>
        public Set<T> Intersection(Set<T> set)
        {
            var result = new Set<T>();
            foreach (T x in set)
            {
                if (this.Find(x))
                {
                    result.Add(x);
                }
            }
            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private List<T> list = new List<T>();
        private int index = 0;
    }
}
