using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dictionary
{
    [Serializable]
    class Linked_List
    {
        public char word;
        Node start;
        Node end;
        public Linked_List(char word)
        {
            this.word = word;
            start = new Node();
            end = new Node();
        }
        public bool Underflow()
        {
            if (start.next != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool InsertFront(string word, string partofspeech, string meaning)
        {
            Node n = new Node(word, partofspeech, meaning);
            if (!Underflow())
            {
                n.next = start.next;
                start.next.previous = n;
                start.next = n;
                sortList();
                return true;
            }
            else
            {
                start.next = n;
                end.previous = n;
                sortList();
                return true;
            }
        }
        public bool InsertLast(string word, string partofspeech, string meaning)
        {
            Node n = new Node(word, partofspeech, meaning);
            if (!Underflow())
            {
                n.previous = end.previous;
                end.previous.next = n;
                end.previous = n;
                
                return true;
            }
            else
            {
                start.next = n;
                end.previous = n;
                
                return true;
            }
        }
        public void DeleteNode(string word)
        {
            if (start == null)
            {
                Console.WriteLine("  " + word + "  Word Not found!!");
                return;
            }
            if (start.next.next == null)   // list has only one node
            {
                if (start.next.word == word)
                    start.next = null;

                else
                    Console.WriteLine("  " + word + "  Word Not found!!");
                return;
            }
            //Deletion of first node
            if (start.next.word == word)
            {
                start = start.next;
                start.previous = null;
                Console.WriteLine("\n\t **** The Word is Deleted from MY DICTIONARY ****");
                return;
            }
            Node p = start.next;
            while (p.next != null)
            {
                if (p.word == word)
                    break;
                p = p.next;
            }
            if (p.next != null)  //node to be deleted is in between
            {
                p.previous.next = p.next;
                p.next.previous = p.previous;
                Console.WriteLine("\n\t **** The Word is Deleted from MY DICTIONARY ****");
            }
            else // p refers to last node
            {
                if (p.word == word)  //node to be deleted is last node
                {
                    p.previous.next = null;
                    Console.WriteLine("\n\t **** The Word is Deleted from MY DICTIONARY ****");
                }
                else
                    Console.WriteLine("  " + word + "  Word not found!!");
            }
        }
        public void Searchandupdate(string word)
        {
            if (start.next != null)
            {
                Node temp = start.next;
                while (temp != null)
                {
                    if (temp.word == word)
                    {
                        Console.WriteLine(" WORD:   " + temp.word + " |*| " + "PART OF SPEECH:  (" + temp.partofspeech + ") |*| " + "MEANING:   " + temp.meaning);
                        Console.Write("\n Do you want to change the name (y/n): ");
                        string yorn = Console.ReadLine();
                        if (yorn == "y" || yorn == "Y")
                        {
                            Console.Write(" Please Enter the word : ");
                            string worda = Console.ReadLine();
                            temp.word = worda;
                        }
                        else 
                        {
                            Console.WriteLine("PLease Enter y to update");
                            
                        }
                        Console.Write("\n Do you want to change the part of speech (y/n): ");
                        string yorno = Console.ReadLine();
                        if (yorno == "y" || yorno == "Y")
                        {
                            Console.Write(" Please Enter the part of speech : ");
                            string worda = Console.ReadLine();
                            temp.partofspeech = worda;
                        }
                        else 
                        {
                            Console.WriteLine("PLease Enter y to update");
                            
                        }
                        Console.Write("\n Do you want to change the meaning (y/n): ");
                        string yornoo = Console.ReadLine();
                        if (yornoo == "y" || yornoo == "Y")
                        {
                            Console.Write(" Please Enter the meaning : ");
                            string worda = Console.ReadLine();
                            temp.meaning = worda;
                        }
                        else 
                        {
                            Console.WriteLine("PLease Enter y to update");
                            return;
                        }
                        Console.WriteLine("\n\t **** The Word is Updated in MY DICTIONARY ****");
                        sortList();
                        return;
                    }
                    temp = temp.next;
                }
                Console.WriteLine("  The word was not found!!");
            }
        }
        public void Search(string word)
        {
            if (start.next != null)
            {
                Node temp = start.next;
                while (temp != null)
                {
                   
                    if (temp.word == word)
                    {
                        Console.WriteLine("\t We have Found the Word...");
                        Console.WriteLine();
                        Console.WriteLine(" WORD:   " + temp.word + " |*| " + "PART OF SPEECH:  (" + temp.partofspeech + ") |*| " + "MEANING:  " + temp.meaning);
                        return;
                    }
                    temp = temp.next;
                }
                Console.WriteLine("\n\t Searched word is Not Present in the MY DICTIONARY");
            }
        }
        public void Display()
        {
            if (start.next != null)
            {
                if (Underflow())
                {
                    Console.WriteLine("  Dictionary is empty!");
                    return;
                }
                Node temp = start.next;
                Console.WriteLine("  " + word + " : ");
                while (temp.next != null)
                {
                    Console.WriteLine(" WORD:   "+temp.word + " |*| " + "PART OF SPEECH:  (" + temp.partofspeech + ") |*| " + "MEANING:  " + temp.meaning);
                    temp = temp.next;
                }
                Console.WriteLine(" WORD:   " + temp.word + " |*| " + "PART OF SPEECH:  (" + temp.partofspeech + ") |*| " + "MEANING:  " + temp.meaning);
            }
        }
        public void sortList()
        {
            Node current = null, index = null;
            string tempword;
            string temppart;
            string tempmeaning;

            if (Underflow())  //Check whether list is empty  
            {
                return;
            }
            else
            {
                //Current will point to head  
                for (current = start.next; current.next != null; current = current.next)
                {
                    //Index will point to node next to current  
                    for (index = current.next; index != null; index = index.next)
                    {
                        //If current's data is greater than index's data, swap the data of current and index  
                        if (current.word.CompareTo(index.word) > 0)
                        {
                            tempword = current.word;
                            temppart = current.partofspeech;
                            tempmeaning = current.meaning;
                            current.word = index.word;
                            current.partofspeech = index.partofspeech;
                            current.meaning = index.meaning;
                            index.word = tempword;
                            index.partofspeech = temppart;
                            index.meaning = tempmeaning;
                        }
                    }
                }
            }
        }
    }
}
