using System.ComponentModel.DataAnnotations;
namespace sda_onsite_2_csharp_backend_teamwork.src.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; } //Foreign Key
        [Required]
        public string Name { get; set; }
       
        public string Img { get; set; }
       
        public string Description { get; set; }
        public int Price { get; set; }
        public List<Inventory>? Inventory { get; set; } // Navigation Property

    }
}