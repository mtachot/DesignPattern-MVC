using MVCpattern.Classes.Models;
using MVCpattern.Classes.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCpattern.Classes.Controllers
{
    public class StudentController
    {
        private Student model;
        private StudentView view;

        public StudentController(Student model, StudentView view)
        {
            this.model = model;
            this.view = view;
        }

        public void SetStudentName(string name)
        {
            this.model.Name = name;
        }
        public string GetStudentName()
        {
            return this.model.Name;
        }

        public void SetStudentRollNo(string rollNo)
        {
            this.model.RollNo = rollNo;
        }
        public string GetStudentRollNo()
        {
            return this.model.RollNo;
        }

        public void UpdateView()
        {
            this.view.PrintStudentDetails(this.model.Name, this.model.RollNo);
        }
    }
}
