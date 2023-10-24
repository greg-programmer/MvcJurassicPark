using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Dinosaur
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        public string ImagePath { get; set; } = "https://static.posters.cz/image/1300/toiles-jurassic-park-classic-logo-i111309.jpg";
        [Required]
        [StringLength(1000)]
        public string Description { get; set; }
        public int SpecyId { get; set; }
        public Specy specy { get; set; }
        [Required]
        public int FoodId { get; set; }  
        public Food food { get; set; }
    }
}
