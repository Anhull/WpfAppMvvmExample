using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfAppMvvm.Model
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepName { get; set; }
        public int EmpChief { get; set; }
    }
    public class Order
    {
        public int OrderId { get; set; }
        public string Good { get; set; }
        public int Emp { get; set; }
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
        public int InDep { get; set; }
    }
}
