using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext  
    {
        public DbSet<Dinosaur> Dinosaurs { get; set; }
        public DbSet<Specy> Species { get; set; }
        public DbSet<Food> Foods { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Food>().HasData(
                new Food { Id = 1, Name = "Carnivore" },
                new Food { Id = 2, Name = "Herbivore" },
                new Food { Id = 3, Name = "Omnivore" }
            );
            builder.Entity<Specy>().HasData(
                new Specy { Id = 1, Name = "Raptor" },
                new Specy { Id = 2, Name = "Tyrannosaurus" },
                new Specy { Id = 3, Name = "Triceratops" },
                new Specy { Id = 4, Name = "Brachiosaurus" },
                new Specy { Id = 5, Name = "Stegosaurus" },
                new Specy { Id = 7 ,Name = "Ankylosaures " }, /*cuirassé*/
                new Specy { Id = 8, Name = "Hadrosaures " } /*bec de canard*/
                );
            builder.Entity<Dinosaur>().HasData(
                new Dinosaur
                {
                    Id = 1,
                    FoodId = 1,
                    SpacyId = 1,
                    ImagePath = "https://imagenes.razon.com.mx/files/image_940_470/files/fp/uploads/2022/11/05/63673d376c8d7.r_d.574-112-0.jpeg",
                    Name = "Blue",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." +
                    " Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." +
                    " Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." +
                    " Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." +
                    " Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " +
                    "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." +
                    " Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
                },
                 new Dinosaur
                 {
                     Id = 2,
                     FoodId = 2,
                     ImagePath = "https://imagenes.razon.com.mx/files/image_940_470/files/fp/uploads/2022/11/05/63673d376c8d7.r_d.574-112-0.jpeg",
                     Name = "Green",
                     Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." +
                    " Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." +
                    " Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." +
                    " Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." +
                    " Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " +
                    "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." +
                    " Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
                 }                
                );
        }
    }
}
