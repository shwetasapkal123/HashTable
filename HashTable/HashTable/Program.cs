using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WEL-COME In Hash Table");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");

            Console.WriteLine(hash.GetV("0"));
            Console.WriteLine(hash.GetV("1"));
            Console.WriteLine(hash.GetV("2"));
            Console.WriteLine(hash.GetV("3"));
            Console.WriteLine(hash.GetV("4"));
            Console.WriteLine(hash.GetV("5"));
            Console.ReadLine();
        }
    }
}
