using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
     class MyMapNode<K,V>
    {
        private int size;
        private LinkedList<KeyValue<K, V>>[] items;

        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
        protected int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
        protected LinkedList<KeyValue<K, V>> GetLinkedList(int pos)
        {
            LinkedList<KeyValue<K, V>> linkedlist = items[pos];
            if (linkedlist == null)
            {
                linkedlist = new LinkedList<KeyValue<K, V>>();
                items[pos] = linkedlist;
            }
            return linkedlist;
        }

        public V GetV(K key)
        {
            int pos = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(pos);
            foreach (KeyValue<K, V> item in linkedlist)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }
        public void Add(K key, V value)
        {
            int pos = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(pos);
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };
            linkedlist.AddLast(item);
        }
        public void Remove(K key)
        {
            int pos = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(pos);
            bool isFound = false;
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> item in linkedlist)
            {
                if (item.Key.Equals(key))
                {
                    isFound = true;
                    foundItem = item;
                }
                if (isFound == true)
                {
                    linkedlist.Remove(foundItem);
                }
            }
        }
        public bool IsEmpty()
        {
            if (Getsize() <= 0)
                return true;
            else
                return false;
        }
        public int Getsize()
        {
            return size;
        }
    }
    public struct KeyValue<k, v>
    {
        public k Key { get; set; }
        public v Value { get; set; }
    }
}

