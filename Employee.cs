using System.ComponentModel.DataAnnotations;

namespace EfCoreTest1
{
    public class Employee
    {
        [Key]
        public int EmployeeCode { get; set; }

        public string FIOemployee { get; set; }

        public int PositionCode { get; set; }

    }
}
