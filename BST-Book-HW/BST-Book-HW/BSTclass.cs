using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_Book_HW
{
    class BSTclass
    {
        BSTnode bstTop;  // our refernece node at the top of the BST

        class BSTnode  // private (by default) class used by BST
        {
            public int bstKey;
            public BSTnode LeftNode;
            public BSTnode RightNode;
            public Book BookValue;

            public BSTnode(int key, Book value)
            {
                bstKey = key;
                BookValue = value;
            }
        }

        public void Add(int keyParam, Book thisBookValue)
        {
            if (bstTop == null) // deal with an empty BST
            {
                bstTop = new BSTnode(keyParam, thisBookValue); // add a new node in the bstTop position
                
                return;   // LeftNode and RightNode will default to null, which is correct
            }
            else  // need to walk the 2 dim tree to find where to add this  
            {
                BSTnode current = bstTop; // since we got here, we know top is not empty

                while (true)
                {
                    if (keyParam < current.bstKey) // if true need to check off to the left
                    {
                        if (current.LeftNode == null) // would mean there are no more nodes on the left
                        {
                            current.LeftNode = new BSTnode(keyParam, thisBookValue); // so make a new one, and change the existing
                            // node's left pointer to point to a new node
                            break;  //  we are bailing out of the while
                        }
                        else
                        {
                            current = current.LeftNode;  // walk down a node, and let the while clause do it again
                        }
                    }
                    else if (keyParam > current.bstKey) // else need to check to the rigth
                    {
                        if (current.RightNode == null) // would mean there are no more nodes on the right
                        {
                            current.RightNode = new BSTnode(keyParam, thisBookValue); // so make a new one, and change the existing
                            // node's right pointer to point to a new node
                            break;  //  we are bailing out of the while
                        }
                        else
                        {
                            current = current.RightNode;  // walk down a node, and let the while clause do it again
                        }
                    }
                    else  // the key is equal to and existing node, and we don't allow duplicates
                    {
                        throw new Exception("MSG from BST class: duplicate values not allowed");
                    }

                }
            }
        }

        public Book Find(int targetKey)  // return true if targetKey value is in the tree 
        {
            Book newBook = new Book(); //Default Book

            if (bstTop == null) // deal with an empty BST
            {                
                return newBook;   // can't be here is there are none
            }
            else  // need to walk the 2 dim tree to try and find it  
            {
                BSTnode current = bstTop; // set our walking pointer node to the top node
                while (current != null) // loop as we walk down the tree unless we get to the bottom before finding it
                {
                    if (targetKey == current.bstKey) // if the current node has the correct value
                    {

                        return current.BookValue;  // we have a match; other wise, we need to move down the right or left branch
                    }
                    else if (targetKey > current.bstKey) // check if we want to follow the left or rigth pointer
                    {
                        current = current.RightNode;  // since target is bigger, we go down the right fork
                        // which might be a null pointer, but our while loop will handle this
                    }
                    else
                    {
                        current = current.LeftNode; // must have been less than, so go down left fork
                    }

                }
                return newBook;
            }
        }
    }
}

