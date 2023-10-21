//using System;
//using System.Collections.Generic;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.SqlServer;
//using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;


//    public class ApplicationContext : DbContext
//    {
//        //public DbSet<Employee> Employees => Set<Employee>();
//        public DbSet<Employee> Employees { get; set; }
//        //public ApplicationContext() => Database.EnsureCreated();

//        public ApplicationContext(DbContextOptions<ApplicationContext> options)
//        : base(options)
//        {

//        }

//        public ApplicationContext() : base()
//        {
//            Database.SetConnectionString("DefaultConnection");            
//        }


//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            optionsBuilder.LogTo(Console.WriteLine);
//            optionsBuilder.UseSqlServer("Data Source=DESKTOP-IET9V1M\\MSSQLSERVER01;Initial Catalog=Employee_db;Integrated Security=True");
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<Employee>().ToTable("Employee");
//            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
//        }
//    }
//



using Microsoft.EntityFrameworkCore;


namespace Employee.Models
{

    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public virtual DbSet<Employee> Employees { get; set; }

        public void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }

        public virtual void SetAdded(object entity)
        {
            Entry(entity).State = EntityState.Added;
        }

        public void SetDeleted(object entity)
        {
            Entry(entity).State = EntityState.Deleted;
        }

        public void SetValue(object currentValue, object newValue)
        {
            Entry(currentValue).CurrentValues.SetValues(newValue);
        }

        public virtual int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
    public interface IApplicationDbContext
    {
        DbSet<Employee> Employees { get; set; }
        void SetModified(object entity);
        void SetAdded(object entity);
        void SetDeleted(object entity);
        void SetValue(object currentValue, object newValue);
        int SaveChanges();
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}