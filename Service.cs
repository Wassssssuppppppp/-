using System.ComponentModel.DataAnnotations;

namespace EfCoreTest1
{
    public class Service
    {
        [Key]
        public int Service_code { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

    }
}
