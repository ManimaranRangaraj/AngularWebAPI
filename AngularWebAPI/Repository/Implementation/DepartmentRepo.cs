using AngularWebAPI.Models;
using AngularWebAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace AngularWebAPI.Repository.Implementation
{
    public class DepartmentRepo: IDepartmentRepo
    {
        public AngularEmployeeDBContext _angularEmployeeDBContext { get; set; }
        public DepartmentRepo(AngularEmployeeDBContext angularEmployeeDBContext) {
            _angularEmployeeDBContext = angularEmployeeDBContext ?? throw new ArgumentNullException(nameof(angularEmployeeDBContext));
        }
        public IEnumerable<Department> GetDepartment()
        {
            return _angularEmployeeDBContext.Departments.ToList();
        }
        public Department AddDepartment(Department objDepartment)
        {
            _angularEmployeeDBContext.Departments.Add(objDepartment);
            _angularEmployeeDBContext.SaveChangesAsync();
            return objDepartment;
        }
        public Department UpdateDepartment(Department objDepartment)
        {
            _angularEmployeeDBContext.Entry(objDepartment).State = EntityState.Modified;
            _angularEmployeeDBContext.SaveChangesAsync();
            return objDepartment;
        }
        public bool DeleteDepartment(int ID)
        {
            bool result = false;
            var department = _angularEmployeeDBContext.Departments.Find(ID);
            if (department != null)
            {
                _angularEmployeeDBContext.Entry(department).State = EntityState.Deleted;
                _angularEmployeeDBContext.SaveChanges();
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
