using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace c__data_structures
{
    /// <summary>
    /// A stack that simultaneously stores matching keys and values
    /// in LIFO order.
    /// </summary>
    /// <typeparam name="K">Key</typeparam>
    /// <typeparam name="V">Value</typeparam>
    public class MapStack<K,V>
    {
        private Stack<K> keyStack;
        private Stack<V> valueStack;

        /// <summary>
        /// Creates a new MapStack()
        /// </summary>
        public MapStack()
        {
            this.keyStack = new Stack<K>();
            this.valueStack = new Stack<V>();
            CheckRep();
        }


        /// <summary>
        /// Add a new key and value
        /// </summary>
        /// <param name="key">key to be added</param>
        /// <param name="value">value to be added</param>
        public void Push(K key, V value)
        {
            keyStack.Push(key);
            valueStack.Push(value);
            CheckRep();
        }

        /// <summary>
        /// Delete and return the topmost item
        /// </summary>
        /// <returns>the topmost item</returns>
        public V Pop()
        {
            keyStack.Pop();
            V value = valueStack.Pop();
            CheckRep();
            return value;
        }

        /// <summary>
        /// Return the topmost item
        /// </summary>
        /// <returns>The topmost item</returns>
        public V Peek()
        {
            return valueStack.Peek();
        }

        /// <summary>
        /// Returns the number of elements
        /// </summary>
        /// <returns>Number of elements</returns>
        public int Count()
        {
            return keyStack.Count;
        }


        /// <summary>
        /// Returns whether the MapStack is empty or not
        /// </summary>
        /// <returns>Whether the MapStack is empty or not</returns>
        public Boolean IsEmpty()
        {
            return keyStack.Count == 0;
        }


        /*
         * Assert that the representation invariants are held:
         */
        private void CheckRep()
        {
            Trace.Assert(keyStack.Count == valueStack.Count);
            Trace.Assert(keyStack.Count == 0 == IsEmpty());
        }
    }
}
