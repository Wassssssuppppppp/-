using System.ComponentModel.DataAnnotations;

namespace EfCoreTest1
{
    public class Product
    {
        [Key]
        public int ProductCode { get; set; }

        public string Title { get; set; }

        public decimal PricePerPiece { get; set; }
        public int? ZakazOrderCode { get; set; }
        public Zakaz? Zakaz { get; set; }
    }
}