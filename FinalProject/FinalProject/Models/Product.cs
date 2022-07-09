using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Product
    {
        [key]
        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }
        public float Price { get; set; }
        public string Brand { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
