using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfAppMvvm.Model
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepName { get; set; }
        public int DepEmpChief { get; set; }
    }
    public class Order
    {
        public int OrderId { get; set; }
        public string OrdGood { get; set; }
        public int OrdEmp { get; set; }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public string EmpMName { get; set; }
        public string EmpSName { get; set; }
        [Column(TypeName ="datetime")]
        public DateTime DateOfBirth { get; set; }
        public enum ChooseOfSex
        {
            Male,
            Fermale
        }
        public ChooseOfSex SexValue { get; set; }
        public int EmpInDep { get; set; }
    }
}
