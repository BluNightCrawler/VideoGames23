using System.ComponentModel.DataAnnotations.Schema;
namespace VideoGames23.Models
{
    public class Product
    {
        public long ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }

        [Column(TypeName="decimal(8,2")]
        public decimal Price { get; set; }

        public string Category { get; set; }

        public string System { get; set; }
    }
}
