using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkerList2
{
    public class Node
    {
        public Student student { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }
        public Node() { }
        public Node(Student student) 
        { 
            this.student = student; 
        }
        
    }
}
