using AngularWebAPI.Models;

namespace AngularWebAPI.Repository.Interface
{
    public interface IDepartmentRepo
    {
        IEnumerable<Department> GetDepartment();
        Department AddDepartment(Department objDepartment);
        Department UpdateDepartment(Department objDepartment);
        bool DeleteDepartment(int ID);
    }
}
