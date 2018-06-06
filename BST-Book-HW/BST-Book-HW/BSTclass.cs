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

        public void Remove(int keyParam)
        {
            //********************************************************************************************
            // handle case if the tree is empty
            //********************************************************************************************

            if (bstTop == null) // deal with an empty BST
            {
                throw new ApplicationException("Trying to remove a node from and empty tree.");
            }

            //********************************************************************************************
            // There is at least one node
            //********************************************************************************************

            // create variables we'll need for the top node or any other node
            BSTnode parentNode = bstTop; // set our walking pointer node to the top node
            BSTnode childNode; // define a node one level down from parent, when we find the right one, 
                               // its what we will remove
            bool CameFromParentsLeftPointer = false; // Need to keep track if we got to the child from a parents 
                                                     // left or right pointer, so when we patch up the links, we patch back up to the correct left or right one

            //********************************************************************************************
            // All the rest of this method is 2 large sections, 
            // top section for removing the top node
            // then latter big section is for removing any other node
            //********************************************************************************************
            if (parentNode.bstKey == keyParam) // are we removing the top node?


            //***************************************************************************************************
            // so here is the first big section dealing with the top node
            // we will not have to walk the tree to find the node, we know its the top node
            // if the top node has 0 or 1 child, we will just adjust the value in the BSTtop pointer
            // but if the top node has 2 children, we will have to walk the tree to find the node to "promote" to the top
            //**************************************************************************************************
            {
                // There are 3 possibilities for the top node, no children, 1 child, or 2 children
                //********************************************************************************************
                // top node has no children
                //********************************************************************************************
                if (parentNode.LeftNode == null && parentNode.RightNode == null)  // removing the one and only node
                {
                    bstTop = null;
                    return; // and then leave
                }

                //********************************************************************************************
                // top node has only 1 child
                //********************************************************************************************
                // at this point we know the child node has either one or two children, so check if its just one
                if (parentNode.LeftNode != null && parentNode.RightNode == null) // parentNode has only a left node
                {
                    bstTop = parentNode.LeftNode; // put the top node's one child node up into the the top  pointer
                    return; // and then leave
                }
                if (parentNode.RightNode != null && parentNode.LeftNode == null) // parentNode has only a right node
                {
                    bstTop = parentNode.RightNode; // put the top node's one child node up into the the top  pointer
                    return; // and then leave
                }
                // if we got here, the 2 if's failed, so we know ...

                //********************************************************************************************
                //  node has 2 children
                //********************************************************************************************

                BSTnode NodeWithKeyValueToOverWrite = parentNode; // save a pointer to the node to be removed by overwriting
                Book tempBook = parentNode.BookValue; //Empty book

                // walk left then rigth to find largest key on the left side of the BST
                // move left  first
                childNode = parentNode.LeftNode; // we know we have a left node at this point, as we know we had 2 children

                // now walk down all right nodes until there are no more
                CameFromParentsLeftPointer = true;  // we always start from the first left node, so remember this
                while (childNode.RightNode != null) // now loop down the right
                {
                    CameFromParentsLeftPointer = false; // if we got inside this while loop, then it is NOT the first left node to remove
                    parentNode = childNode;
                    childNode = parentNode.RightNode;
                }

                //*********************************************************************************************
                // at this point the childNode pointer is a copy of the node we want to copy to the top and then remove
                // either the bottom far right node or it might have been the lonely 1st left node
                // as we remove this node, there are only 2 cases, this node has no children, or it has 1 left node
                // else we would have moved further to the right.
                //*********************************************************************************************

                // first see if this node to remove has no children
                if (childNode.LeftNode == null) // if left is null, there are no children <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
                {
                    if (CameFromParentsLeftPointer) // this is that one case where it was the first node on left we want to get ride of
                    {
                        parentNode.LeftNode = null; // snip off from the parent's left side and its gone
                    }
                    else // must have CameFromParents Right Pointer
                    {
                        parentNode.RightNode = null; // snip off from the parent's right side and its gone
                    }

                    // before we leave, we want to overwrite the NodeWithKeyValueToOverWrite's keyValue (the one we are logically removing)
                    //  with the keyValue of this childNode's keyValue. 
                    NodeWithKeyValueToOverWrite.bstKey = childNode.bstKey;// (in this top section, the NodeWithKeyValueToOverWrite is really the top node
                    tempBook = childNode.BookValue;                                                      // but the algorithm works here, and then below in the second section where it won't be the top node we are overwriting.
                }
                //*********************************************************************************
                else  // if hit this else, it means the node to remove DOES have a valid left pointer (but it cannot have a rigth pointer, else we wouldn't be here)
                {
                    if (CameFromParentsLeftPointer) // this is that one case where it was the first node on left we want to get ride of
                    {
                        parentNode.LeftNode = childNode.LeftNode; // clone the childs left branch onto the parent's pointer, leaving the child an orphan
                    }
                    else // we had started moving downt he rigth, so we want to wire up this orphan LeftNode to the parent's rigth pointer
                    {
                        parentNode.RightNode = childNode.LeftNode; // clone the childs left branch onto the parent's pointer, leaving the child an orphan
                    }

                    // before we leave, we want to overwrite the NodeWithKeyValueToOverWrite's keyValue (the one we thought we
                    // wanted to remove) with the keyValue of this "1 to the left, all the way to the right" node's keyValue.
                    NodeWithKeyValueToOverWrite.bstKey = childNode.bstKey;
                    tempBook = childNode.BookValue;
                }
                return;  // we have removed the node


            }
        }
    }
}

