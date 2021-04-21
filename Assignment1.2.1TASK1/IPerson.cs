using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._2._1TASK1
{
    interface IPerson
    {
        
         float Penalty { get ; set ; }
         int BorrowedCount { get ; set ; }

        string Name { get; set; }

        //void Borrow();
    }
}
