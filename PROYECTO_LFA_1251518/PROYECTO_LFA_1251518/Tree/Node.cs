﻿using System.Collections.Generic;

namespace PROYECTO_LFA_1251518
{
    public class Node
    {
        private string simbol;
        private LinkedList<int> first;
        private LinkedList<int> last;
        private LinkedList<int> follow;
        private bool nullable;

        public Node(string simbol)
        {
            this.Simbol = simbol;
            this.first = new LinkedList<int>();
            this.last = new LinkedList<int>();
            this.follow = new LinkedList<int>();
            this.nullable = false;
        }

        public string Simbol
        {
            get{ return this.simbol;}
            set{ this.simbol = value;}
        }

        public bool Nullable
        {
            get { return this.nullable; }
            set { this.nullable = value; }
        }

        public LinkedList<int> First
        {
            get{ return this.first;}
            set{ this.first = value;}
        }

        public LinkedList<int> Last
        {
            get { return this.last; }
            set { this.last = value; }
        }

        public LinkedList<int> Follow
        {
            get { return this.follow; }
            set { this.follow = value; }
        }
    }

}
