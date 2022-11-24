using System.ComponentModel.DataAnnotations;

namespace EfCoreTest1
{
    public class StoreAddress
    {
        [Key]
        public int Store_addres_code { get; set; }

        public string Store_address { get; set; }

    }
}
