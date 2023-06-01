using AngularWebAPI.Repository.Interface;
using AngularWebAPI.Models;

namespace AngularWebAPI.Repository.Implementation
{
    public class EmployeeRepo: IEmployeeRepo
    {
        AngularEmployeeDBContext _angularEmployeeDBContext;
        public EmployeeRepo(AngularEmployeeDBContext angularEmployeeDBContext) { 
            _angularEmployeeDBContext = angularEmployeeDBContext;
        }
        public IDepartmentRepo DepartmentRepo => new DepartmentRepo(_angularEmployeeDBContext);
        public IStudentRepo StudentRepo => new StudentRepo(_angularEmployeeDBContext);
    }
}
