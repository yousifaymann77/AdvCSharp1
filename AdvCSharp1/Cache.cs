using System;
using System.Collections.Generic;
using System.Text;

namespace AdvCSharp1
{
    #region Q20: Complete Exercise - Create a generic Cache<TKey, TValue>with Add, Get, Remove, Contains, and expiration support. 
    internal class Cache<TKey, TValue> where TKey : IComparable<TKey>
    {

        public TKey Key { get; set; }
        public TValue Value { get; set; }
        public DateTime expiration;
        public bool exists;

        public void Add(TKey key, TValue value, TimeSpan expiration)
        {
            Key = key;
            Value = value;
            this.expiration = DateTime.Now.Add(expiration);
            exists = true;
        }

        public TValue GetKey(TKey key)
        {
            if (!Contains(key))
                return default;

            return Value;
        }

        public void Remove(TKey key)
        {
            if (Contains(key))
            {
                exists = false;
            }
        }

        public bool Contains(TKey key)
        {
            if (!exists || Key.CompareTo(key) != 0)
                return false;

            if (DateTime.Now > expiration)
            {
                exists = false;
                return false;
            }

            return true;
        }

    } 
    #endregion
}
