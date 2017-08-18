using MVCpattern.Classes.Controllers;
using MVCpattern.Classes.Models;
using MVCpattern.Classes.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCpattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Fetch student record based on his roll No from the database
            Student model = RetriveStudentFromDatabase();

            // Create a view to write student details in console
            StudentView view = new StudentView();

            // Finally, instantiating the controller
            StudentController controller = new StudentController(model, view);
            controller.UpdateView();

            // Update model data and reprint student infos
            model.Name = "Bob";
            controller.UpdateView();

            Console.ReadLine();
        }

        private static Student RetriveStudentFromDatabase()
        {
            Student student = new Student();
            student.Name = "Alice";
            student.RollNo = "10";
            return student;
        }
    }
}
