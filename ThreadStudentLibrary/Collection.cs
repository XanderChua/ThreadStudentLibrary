using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadStudentLibrary
{
    class Collection<T>
    {
        private List<T> _collection;
        public List<T> CollectionObj
        {
            get
            {
                if(_collection == null)
                {
                    _collection = new List<T>();
                }
                return _collection;
            }
            private set
            {
                _collection = value;
            }
        }
        public void addCollection(T item)
        {
            CollectionObj.Add(item);
        }
        public void removeCollection(T item)
        {
            CollectionObj.Remove(item);
        }
        public T this[int index]
        {
            get { return CollectionObj[index]; }
            set { CollectionObj[index] = value; }
        }
    }
}
