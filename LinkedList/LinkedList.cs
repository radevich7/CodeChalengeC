



namespace LinkedList
{
    internal class Node
    {
        internal int data;
        internal Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

        internal void InsertFront(SingleLinkedList singleList, int newData)
        {
            Node newNode = new Node(newData);
            newNode.next = singleList.head;
            singleList.head = newNode;

        }
    }



    internal class DoubleNode
    {
        internal int data;
        internal DoubleNode next;
        internal DoubleNode previous;

        public DoubleNode(int d)
        {
            data = d;
            previous = null;
            next = null;
        }

        internal void InsertFront(DoubleLinkedList doubleList, int newData)
        {
            DoubleNode newNode = new DoubleNode(newData);
            newNode.next = doubleList.head;
            newNode.previous = null;
            if(doubleList.head != null)
            {
                doubleList.head.next = newNode;
            }
            doubleList.head = newNode;

        }
    }

    internal class SingleLinkedList
    {
        internal Node head;
    }
    internal class DoubleLinkedList
    {
        internal DoubleNode head;
    }



}