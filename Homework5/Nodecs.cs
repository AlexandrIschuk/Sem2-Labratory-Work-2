using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class Node
    {
        private int info;
        private Node link;
        public int Info
        {
            get { return info; }
            set { info = value; }
        }
        public Node Link
        {
            get { return link; }
            set { link = value; }
        }
        public Node(int info)
        { this.info = info; }
        public Node(int info, Node link)
        {
            Info = info;
            Link = link;
        }
    }
}
