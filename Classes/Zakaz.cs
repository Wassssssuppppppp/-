using System.ComponentModel.DataAnnotations;

namespace EfCoreTest1
{
    public class Zakaz
    {
        [Key]
        public int OrderCode { get; set; }

        public int? ClientCode { get; set; }

        public int? ProductCode { get; set; }

        public int? EmployeeCode { get; set; }

        public int? ServiceCode { get; set; }

        public int? StoreAddressesCode { get; set; }

        public string Status { get; set; }

        public DateTime? OrderDate { get; set; }
        public LinkedList<Product> Product { get; set; } = new();

    }
}