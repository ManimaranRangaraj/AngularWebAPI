namespace AngularWebAPI.Repository.Interface
{
    public interface IEmployeeRepo
    {
        IDepartmentRepo DepartmentRepo { get; }
        IStudentRepo StudentRepo { get; }
    }
}
