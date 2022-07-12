using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dictionary
{
    [Serializable]
    class Node
    {
        public string word;
        public string meaning;
        public string partofspeech;
        public Node next;
        public Node previous;

        public Node()
        {

        }
        public Node(string word, string partofspeech, string meaning)
        {
            this.word = word;
            this.meaning = meaning;
            this.partofspeech = partofspeech;
            this.next = null;
            this.previous = null;
        }

    }
}
