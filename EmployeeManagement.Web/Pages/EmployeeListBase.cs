using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployees);
            //return base.OnInitializedAsync();
        }
        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(30000);
            Employee e1 = new Employee()
            {
                EmployeeId = 1,
                FirstName = "John",
                Lastname = "Hastings",
                Email = "David@PragimTech.com",
                DateOfBirth = new DateTime(1980,10,5),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/john1.png"
            };
            Employee e2 = new Employee()
            {
                EmployeeId = 2,
                FirstName = "John2",
                Lastname = "Hastings2",
                Email = "David2@PragimTech.com",
                DateOfBirth = new DateTime(1980, 10, 6),
                Gender = Gender.Female,
                DepartmentId = 2,
                PhotoPath = "images/john2.png"
            };
            Employee e3 = new Employee()
            {
                EmployeeId = 3,
                FirstName = "John3",
                Lastname = "Hastings3",
                Email = "David3@PragimTech.com",
                DateOfBirth = new DateTime(1980, 10, 7),
                Gender = Gender.Other,
                DepartmentId = 3,
                PhotoPath = "images/john3.png"
            };
            Employee e4 = new Employee()
            {
                EmployeeId = 4,
                FirstName = "John4",
                Lastname = "Hastings4",
                Email = "David4@PragimTech.com",
                DateOfBirth = new DateTime(1980, 10, 8),
                Gender = Gender.Male,
                DepartmentId = 4,
                PhotoPath = "images/john4.png"
            };
            Employees = new List<Employee> { e1, e2, e3, e4 };
        }
    }
}
