namespace Employee.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? DepartmentName { get; set; }
        public int? Basic { get; set; }
        public int? DA { get; set; }
        public int? HRA { get; set; }
        public int? NetSalary { get; set; }
    }
}
