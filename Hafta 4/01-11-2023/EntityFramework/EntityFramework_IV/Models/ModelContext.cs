using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EntityFramework_IV.Models
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Departmentsa1> Departmentsa1s { get; set; } = null!;
        public virtual DbSet<EmpDetailsView> EmpDetailsViews { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Employee1> Employee1s { get; set; } = null!;
        public virtual DbSet<Employee2> Employee2s { get; set; } = null!;
        public virtual DbSet<Employee3> Employee3s { get; set; } = null!;
        public virtual DbSet<Employee4> Employee4s { get; set; } = null!;
        public virtual DbSet<Employee5> Employee5s { get; set; } = null!;
        public virtual DbSet<Employee6> Employee6s { get; set; } = null!;
        public virtual DbSet<Employeea1> Employeea1s { get; set; } = null!;
        public virtual DbSet<Employeea2> Employeea2s { get; set; } = null!;
        public virtual DbSet<Employeea3> Employeea3s { get; set; } = null!;
        public virtual DbSet<Employeea4> Employeea4s { get; set; } = null!;
        public virtual DbSet<Employeea5> Employeea5s { get; set; } = null!;
        public virtual DbSet<Job> Jobs { get; set; } = null!;
        public virtual DbSet<JobHistory> JobHistories { get; set; } = null!;
        public virtual DbSet<Kurslar> Kurslars { get; set; } = null!;
        public virtual DbSet<Location> Locations { get; set; } = null!;
        public virtual DbSet<Order1> Order1s { get; set; } = null!;
        public virtual DbSet<Region> Regions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("User Id = hr; Password = HR; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SID = orcl)))");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("HR")
                .UseCollation("USING_NLS_COMP");

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("COUNTRIES");

                entity.Property(e => e.CountryId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRY_ID")
                    .IsFixedLength();

                entity.Property(e => e.CountryName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRY_NAME");

                entity.Property(e => e.RegionId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REGION_ID");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Countries)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("COUNTR_REG_FK");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("DEPARTMENTS");

                entity.HasIndex(e => e.LocationId, "DEPT_LOCATION_IX");

                entity.Property(e => e.DepartmentId)
                    .HasPrecision(4)
                    .HasColumnName("DEPARTMENT_ID");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT_NAME");

                entity.Property(e => e.LocationId)
                    .HasPrecision(4)
                    .HasColumnName("LOCATION_ID");

                entity.Property(e => e.ManagerId)
                    .HasPrecision(6)
                    .HasColumnName("MANAGER_ID");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("DEPT_LOC_FK");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("DEPT_MGR_FK");
            });

            modelBuilder.Entity<Departmentsa1>(entity =>
            {
                entity.HasKey(e => e.DeptId)
                    .HasName("SYS_C007459");

                entity.ToTable("DEPARTMENTSA1");

                entity.Property(e => e.DeptId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEPT_ID");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEPT_NAME");
            });

            modelBuilder.Entity<EmpDetailsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EMP_DETAILS_VIEW");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CITY");

                entity.Property(e => e.CommissionPct)
                    .HasColumnType("NUMBER(2,2)")
                    .HasColumnName("COMMISSION_PCT");

                entity.Property(e => e.CountryId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRY_ID")
                    .IsFixedLength();

                entity.Property(e => e.CountryName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRY_NAME");

                entity.Property(e => e.DepartmentId)
                    .HasPrecision(4)
                    .HasColumnName("DEPARTMENT_ID");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT_NAME");

                entity.Property(e => e.EmployeeId)
                    .HasPrecision(6)
                    .HasColumnName("EMPLOYEE_ID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FIRST_NAME");

                entity.Property(e => e.JobId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("JOB_ID");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("JOB_TITLE");

                entity.Property(e => e.LastName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LAST_NAME");

                entity.Property(e => e.LocationId)
                    .HasPrecision(4)
                    .HasColumnName("LOCATION_ID");

                entity.Property(e => e.ManagerId)
                    .HasPrecision(6)
                    .HasColumnName("MANAGER_ID");

                entity.Property(e => e.RegionName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("REGION_NAME");

                entity.Property(e => e.Salary)
                    .HasColumnType("NUMBER(8,2)")
                    .HasColumnName("SALARY");

                entity.Property(e => e.StateProvince)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("STATE_PROVINCE");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("EMPLOYEES");

                entity.HasIndex(e => e.DepartmentId, "EMP_DEPARTMENT_IX");

                entity.HasIndex(e => e.Email, "EMP_EMAIL_UK")
                    .IsUnique();

                entity.HasIndex(e => e.JobId, "EMP_JOB_IX");

                entity.HasIndex(e => e.ManagerId, "EMP_MANAGER_IX");

                entity.HasIndex(e => new { e.LastName, e.FirstName }, "EMP_NAME_IX");

                entity.Property(e => e.EmployeeId)
                    .HasPrecision(6)
                    .HasColumnName("EMPLOYEE_ID");

                entity.Property(e => e.CommissionPct)
                    .HasColumnType("NUMBER(2,2)")
                    .HasColumnName("COMMISSION_PCT");

                entity.Property(e => e.DepartmentId)
                    .HasPrecision(4)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DEPARTMENT_ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FIRST_NAME");

                entity.Property(e => e.HireDate)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("HIRE_DATE");

                entity.Property(e => e.JobId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("JOB_ID");

                entity.Property(e => e.LastName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LAST_NAME");

                entity.Property(e => e.ManagerId)
                    .HasPrecision(6)
                    .HasColumnName("MANAGER_ID");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PHONE_NUMBER");

                entity.Property(e => e.Salary)
                    .HasColumnType("NUMBER(8,2)")
                    .HasColumnName("SALARY");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("EMP_DEPT_FK");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("EMP_JOB_FK");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.InverseManager)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("EMP_MANAGER_FK");
            });

            modelBuilder.Entity<Employee1>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("SYS_C007453");

                entity.ToTable("EMPLOYEE1");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EMPLOYEE_ID");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Hiredate)
                    .HasColumnType("DATE")
                    .HasColumnName("HIREDATE");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Salary)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SALARY");
            });

            modelBuilder.Entity<Employee2>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK_EMPLOYEE2_EMPID");

                entity.ToTable("EMPLOYEE2");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EMPLOYEE_ID");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Hiredate)
                    .HasColumnType("DATE")
                    .HasColumnName("HIREDATE");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Salary)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SALARY");
            });

            modelBuilder.Entity<Employee3>(entity =>
            {
                entity.HasKey(e => e.Hiredate)
                    .HasName("PK_EMPLOYEE3_EMPID");

                entity.ToTable("EMPLOYEE3");

                entity.Property(e => e.Hiredate)
                    .HasColumnType("DATE")
                    .HasColumnName("HIREDATE");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EMPLOYEE_ID");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Salary)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SALARY");
            });

            modelBuilder.Entity<Employee4>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK_EMPLOYEE4_EMPID");

                entity.ToTable("EMPLOYEE4");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EMPLOYEE_ID");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Hiredate)
                    .HasColumnType("DATE")
                    .HasColumnName("HIREDATE");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Salary)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SALARY");
            });

            modelBuilder.Entity<Employee5>(entity =>
            {
                entity.HasKey(e => e.Firstname)
                    .HasName("PK_EMPLOYEE5_FIRSTNAME");

                entity.ToTable("EMPLOYEE5");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EMPLOYEE_ID");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");
            });

            modelBuilder.Entity<Employee6>(entity =>
            {
                entity.HasKey(e => new { e.Firstname, e.Lastname })
                    .HasName("PK_EMPLOYEE6_FIRSTLASTNAME");

                entity.ToTable("EMPLOYEE6");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EMPLOYEE_ID");
            });

            modelBuilder.Entity<Employeea1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EMPLOYEEA1");

                entity.Property(e => e.DeptId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEPT_ID");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EMPLOYEE_ID");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");
            });

            modelBuilder.Entity<Employeea2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EMPLOYEEA2");

                entity.Property(e => e.DeptId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEPT_ID");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EMPLOYEE_ID");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");

                entity.HasOne(d => d.Dept)
                    .WithMany()
                    .HasForeignKey(d => d.DeptId)
                    .HasConstraintName("FK_EMP_DEPT_DEPTID");
            });

            modelBuilder.Entity<Employeea3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EMPLOYEEA3");

                entity.HasIndex(e => e.TelephoneNumber, "SYS_C007464")
                    .IsUnique();

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EMPLOYEE_ID");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.TelephoneNumber)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TELEPHONE_NUMBER");
            });

            modelBuilder.Entity<Employeea4>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EMPLOYEEA4");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EMPLOYEE_ID");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Salary)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SALARY");
            });

            modelBuilder.Entity<Employeea5>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EMPLOYEEA5");

                entity.Property(e => e.DeptId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEPT_ID");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EMPLOYEE_ID");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Salary)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SALARY");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("JOBS");

                entity.Property(e => e.JobId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("JOB_ID");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("JOB_TITLE");

                entity.Property(e => e.MaxSalary)
                    .HasPrecision(6)
                    .HasColumnName("MAX_SALARY");

                entity.Property(e => e.MinSalary)
                    .HasPrecision(6)
                    .HasColumnName("MIN_SALARY");
            });

            modelBuilder.Entity<JobHistory>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.StartDate })
                    .HasName("JHIST_EMP_ID_ST_DATE_PK");

                entity.ToTable("JOB_HISTORY");

                entity.HasIndex(e => e.DepartmentId, "JHIST_DEPARTMENT_IX");

                entity.HasIndex(e => e.EmployeeId, "JHIST_EMPLOYEE_IX");

                entity.HasIndex(e => e.JobId, "JHIST_JOB_IX");

                entity.Property(e => e.EmployeeId)
                    .HasPrecision(6)
                    .HasColumnName("EMPLOYEE_ID");

                entity.Property(e => e.StartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("START_DATE");

                entity.Property(e => e.DepartmentId)
                    .HasPrecision(4)
                    .HasColumnName("DEPARTMENT_ID");

                entity.Property(e => e.EndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("END_DATE");

                entity.Property(e => e.JobId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("JOB_ID");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.JobHistories)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("JHIST_DEPT_FK");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.JobHistories)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("JHIST_EMP_FK");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobHistories)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("JHIST_JOB_FK");
            });

            modelBuilder.Entity<Kurslar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KURSLAR");

                entity.Property(e => e.Baslangictarihi)
                    .HasColumnType("DATE")
                    .HasColumnName("BASLANGICTARIHI");

                entity.Property(e => e.Bitistarihi)
                    .HasColumnType("DATE")
                    .HasColumnName("BITISTARIHI");

                entity.Property(e => e.EgitmenAdi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EGITMEN_ADI");

                entity.Property(e => e.KursAdi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("KURS_ADI");

                entity.Property(e => e.KursId)
                    .HasPrecision(3)
                    .HasColumnName("KURS_ID");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("LOCATIONS");

                entity.HasIndex(e => e.City, "LOC_CITY_IX");

                entity.HasIndex(e => e.CountryId, "LOC_COUNTRY_IX");

                entity.HasIndex(e => e.StateProvince, "LOC_STATE_PROVINCE_IX");

                entity.Property(e => e.LocationId)
                    .HasPrecision(4)
                    .HasColumnName("LOCATION_ID");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CITY");

                entity.Property(e => e.CountryId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRY_ID")
                    .IsFixedLength();

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("POSTAL_CODE");

                entity.Property(e => e.StateProvince)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("STATE_PROVINCE");

                entity.Property(e => e.StreetAddress)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("STREET_ADDRESS");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("LOC_C_ID_FK");
            });

            modelBuilder.Entity<Order1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ORDER1");

                entity.Property(e => e.Amount)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Country)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRY");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ORDER_DATE")
                    .HasDefaultValueSql("(sysdate)");

                entity.Property(e => e.OrderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ORDER_ID");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.ToTable("REGIONS");

                entity.Property(e => e.RegionId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REGION_ID");

                entity.Property(e => e.RegionName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("REGION_NAME");
            });

            modelBuilder.HasSequence("DEPARTMENTS_SEQ").IncrementsBy(10);

            modelBuilder.HasSequence("EMPLOYEES_SEQ");

            modelBuilder.HasSequence("LOCATIONS_SEQ").IncrementsBy(100);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
