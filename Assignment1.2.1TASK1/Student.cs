using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._2._1TASK1
{
    class Student:IPerson
    {
        private float penalty;
        private int borrowedCount;
        private string name;
        public Student()
        {

        }

        public Student(float penalty, int borrowedCount)
        {
            Penalty = penalty;
            BorrowedCount = borrowedCount;
        }

        public float Penalty { get => penalty; set => penalty = value; }
        public int BorrowedCount { get => borrowedCount; set => borrowedCount = value; }
        public string Name { get => name; set => name = value; }

        //public void Borrow();
    }
}
