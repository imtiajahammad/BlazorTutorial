using EmployeeManagement.Models;

namespace EmployeeManagement.Api.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext appDbContext;
        public DepartmentRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Department> GetDepartments()
        {
            return appDbContext.Departments;
        }

        public Department GetDepartment(int departmentId)
        {
            var department = appDbContext.Departments.FirstOrDefault(d => d.Departmentid == departmentId);
            if (department == null)
            {
                return new Department();
            }
            return department;
        }
    }
}
