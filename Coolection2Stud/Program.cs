using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coolection2Stud
{
    




    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);

            list.AddFirst(5);

            list.InsertAfter(30, 35);

            list.Show();

            list.Remove(5);

            list.Show();


        }
    }
}
