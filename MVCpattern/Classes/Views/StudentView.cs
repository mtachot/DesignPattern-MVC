using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCpattern.Classes.Views
{
    public class StudentView
    {
        public void PrintStudentDetails(string studentName, string studentRollNo)
        {
            Console.WriteLine(String.Format("Student \nName: {0} \nRoll No: {1}", studentName, studentRollNo));
            Console.WriteLine("");
        }
    }
}
