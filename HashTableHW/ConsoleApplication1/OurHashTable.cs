using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class LLnode
    {

        public int NodeKey
        { get; set; }
        public string NodeValue { get; set; }
        //public LLnode(int key, string value)
        //{
        //    int nodeKey = key;
        //    string nodeValue = value;
        //}
    }

    public class OurHashTable
    {
        // this new array of linked lists is what you will use instead of the string[] above
        LinkedList<LLnode>[] betterHashTable; // new hash table storage is an array of Linked lists

        // constructor --- user specifies how big the table they want to use
        public OurHashTable(int pSize)
        {
            betterHashTable = new LinkedList<LLnode>[pSize]; //Creates an array of LLs
        }

        public bool AddItem(int key, string value)
        {
            LLnode thisNode = new LLnode();
            thisNode.NodeKey = key;
            thisNode.NodeValue = value;

            int hashedKey = HashMul(key);
         
            if (betterHashTable[hashedKey] == null)
            {
                betterHashTable[hashedKey] = new LinkedList<LLnode>(); //Creates a new linked list of type LLNode
                betterHashTable[hashedKey].AddFirst(thisNode);//Adds the new node with values to the first array slot.
            }
            else
            {
                betterHashTable[key].AddFirst(thisNode); //Adds to the top of an exsisting LL
            }
            return true; //***** Come back to this
        }


        public string GetItem(int key)  // notice has fast a look up is!
        {
            int hasedKey = HashMul(key);
            
            if(betterHashTable[hasedKey] == null)
            {
                return ""; //No value for that key
            }
            else
            {
                for(var node = betterHashTable[hasedKey].First; node != null; node = node.Next) //Move along a LL
                {
                    if (betterHashTable[hasedKey].ElementAt(0).NodeKey == key) //Index of element needed is 0
                    {
                        return betterHashTable[hasedKey].ElementAt(0).NodeValue;
                    }
                }
                return "";
            }
        }

        internal void PrintState()  // this is sort of a diagnostic aid, wouldn't normally have this
        {
            Console.WriteLine();
            Console.WriteLine("This is what is in the hash table.");
            Console.WriteLine();
            for (int j = 0; j < 15; j++)
            {
                Console.WriteLine("{0,3}    {1,3}", j, betterHashTable[j]);
            }
        }

        // this is our key hashing algorithm, (using multiply) we could repalce this with other ones to try them out
        public int HashMul(int key)
        {
            int tableSize = betterHashTable.Length;
            double Multiplier = .6180339887;  // must be > 0 but less than 1
            // Knuth suggests .6180339887 Multiplier 
            double dblKey = key; // convert the int key into a double precision floating point
            double percent = Multiplier * dblKey;
            percent = percent - (int)percent; // get the fractional part
            return (int)(Math.Floor(percent * tableSize)); // round down to make sure you have a number that is within the table size
        }

    }
}
