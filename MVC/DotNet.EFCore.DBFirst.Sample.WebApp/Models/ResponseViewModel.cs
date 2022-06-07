namespace DotNet.EFCore.DBFirst.Sample.WebApp.Models
{
    public class ResponseViewModel
    {
        public List<Department>? Departments { get; set;}
        public List<Skill>? Skills { get; set; }
        public List<Employee>? Employees { get; set; }
        public List<EmployeeSkill>? EmployeeSkills { get; set; }
    }
}
