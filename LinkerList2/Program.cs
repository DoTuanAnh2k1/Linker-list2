using LinkerList2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    public class Program
    {
        public static void Main()
        {
            List list = new List();
            DateTime k = new DateTime(2000, 1, 2, 3, 4, 5);
            Student s1 = new Student(1, "Chon", k, GenderInfo.Male, "ET1.06 - K65");
            Student s2 = new Student(1, "Hung", k, GenderInfo.Male, "ET1.06 - K65");
            Student s3 = new Student(1, "Hlam", k, GenderInfo.Male, "ET_E9.01 - K65");
            Student s4 = new Student(1, "Minh", k, GenderInfo.Male, "ET_E4.02 - K66");
            Student s5 = new Student(1, "Than", k, GenderInfo.Male, "ET1.0x - K66");
            Student s6 = new Student(1, "SDuy", k, GenderInfo.Male, "ET1.03 - K65");


            list.PushBack(s1);
            list.PushBack(s2);
            list.PushBack(s3);
            list.PushBack(s4);
            list.PushBack(s5);
            list.PushBack(s6);

            list.Print();

            list.DeleteFirst();
            list.Print();

            list.DeleteLast();
            list.Print();
        }
    }
}
