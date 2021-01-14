using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_9_1_ADS
{
    class BinomialHeap
    {
        private Node head;
        public BinomialHeap()
        {
            head = null;
        }
        public BinomialHeap(Node head)
        {
            this.head = head;
        }
        
        public void Add(int key)
        {
            Node node = new Node(key);
            BinomialHeap tempHeap = new BinomialHeap(node);
            head = UnionTree(tempHeap);
        }
        private Node UnionTree(BinomialHeap Heap)
        {
            Node new_head = Merge(this, Heap);
            head = null;
            Heap.head = null;
            if (new_head == null)
                return null;

            Node prev = null;
            Node current = new_head;
            Node next = new_head.sibling;

            while (next != null)
            {
                if (current.degree != next.degree ||
                    (next.sibling != null && next.sibling.degree == current.degree))
                {
                    prev = current;
                    current = next;
                }
                else if (current.key < next.key)
                {
                    current.sibling = next.sibling;
                    BuildTree(current, next);
                }
                else
                {
                    if (prev == null)
                        new_head = next;
                    else
                        prev.sibling = next;

                    BuildTree(next, current);

                    current = next;
                }
                next = current.sibling;
            }
            return new_head;
        }
        private Node Merge(BinomialHeap Heap1, BinomialHeap Heap2)
        {
            if (Heap1.head == null)
                return Heap2.head;
            else if (Heap2.head == null)
                return Heap1.head;
            else
            {
                Node new_head;
                Node heap1_next = Heap1.head;
                Node heap2_next = Heap2.head;

                if (Heap1.head.degree <= Heap2.head.degree)
                {
                    new_head = Heap1.head;
                    heap1_next = heap1_next.sibling;
                }
                else
                {
                    new_head = Heap2.head;
                    heap2_next = heap2_next.sibling;
                }

                Node end = new_head;
                while (heap1_next != null && heap2_next != null)
                {
                    if (heap1_next.degree <= heap2_next.degree)
                    {
                        end.sibling = heap1_next;
                        heap1_next = heap1_next.sibling;
                    }
                    else
                    {
                        end.sibling = heap2_next;
                        heap2_next = heap2_next.sibling;
                    }
                    end = end.sibling;
                }

                if (heap1_next != null)
                    end.sibling = heap1_next;
                else end.sibling = heap2_next;

                return new_head;
            }
        }
        private void BuildTree(Node root, Node sub_root)
        {
            sub_root.parent = root;
            sub_root.sibling = root.child;
            root.child = sub_root;
            root.degree++;
        }
        internal void DeleteMin()
        {
            if (head == null)
            {
                Console.Write("Куча пуста");
                return;
            }

            Node next = head.sibling;

            Node min_root = head;
            Node prev_min = null;
            Node prev_next = min_root;
            while (next != null)
            {
                if (next.key < min_root.key)
                {
                    min_root = next;
                    prev_min = prev_next;
                }
                prev_next = next;
                next = next.sibling;
            }
            Console.WriteLine("Элемент " + min_root.key + " удален ");
            RemoveRoot(min_root, prev_min);

        }
        private void RemoveRoot(Node root, Node prev_root)
        {
            if (root == head)
                head = root.sibling;
            else prev_root.sibling = root.sibling;

            Node new_head = null;
            Node child = root.child;

            while (child != null)
            {
                Node other_child = child.sibling;
                child.sibling = new_head;
                child.parent = null;
                new_head = child;
                child = other_child;
            }

            BinomialHeap new_heap = new BinomialHeap(new_head);

            head = UnionTree(new_heap);
        }
        internal void Print()
        {

            if (head != null)
            {
                if (head.sibling != null)
                    head.Print("", NodePosition.head, false, false);
                else head.Print("", NodePosition.head, true, false);
            }
            else Console.WriteLine("Куча пуста");
        }
    }

}

