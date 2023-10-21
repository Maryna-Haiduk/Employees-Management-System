using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Employee
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee.Models.Employee>
    {
        public void Configure(EntityTypeBuilder<Employee.Models.Employee> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("Id");
            builder.Property(x => x.FirstName).HasColumnName("First Name").HasMaxLength(100).IsRequired();
            builder.Property(x => x.LastName).HasColumnName("Last Name").HasMaxLength(100).IsRequired();
            builder.Property(x => x.DepartmentName).HasColumnName("Department Name").HasMaxLength(300);
        }
    }
}
