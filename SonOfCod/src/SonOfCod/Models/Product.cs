using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SonOfCod.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ScientificName { get; set; }
        public string MarketName { get; set; }
        public string PrimarySource { get; set; }
        public string Season { get; set; }
        public string FishingMethod { get; set; }
        public int MaxSize { get; set; }
        public int AverageSize { get; set; }
        public string Summary { get; set; }
        public string ProductFormFresh { get; set; }
        public string ProductFormFrozen { get; set; }
        public string StorageHandling { get; set; }
        public string CookingSuggestion { get; set; }
        public string SellingPoints { get; set; }
        public string Defects { get; set; }
        public int Cost { get; set; }
    }
}