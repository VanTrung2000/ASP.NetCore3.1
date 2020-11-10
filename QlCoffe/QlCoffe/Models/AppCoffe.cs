using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QlCoffe.Models
{
    public class AppCoffe : IdentityDbContext
    {
        public DbSet<Coffe> coffes { set; get; }
        public DbSet<User> users { set; get; }
        public DbSet<Category> categories { set; get; }

        public AppCoffe(DbContextOptions<AppCoffe> dbContextOptions) : base(dbContextOptions)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, CategoryName = "Cafe" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, CategoryName = "Trà sữa" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, CategoryName = "Nước ép hoa quả" });

            modelBuilder.Entity<Coffe>().HasData(new Coffe


            {
                Id = 1,
                NameCoffe = "ESPRESSO",
                Price = 35.000,
                Despition = "Một cốc Espresso nguyên bản được bắt đầu bởi những hạt Arabica chất lượng, phối trộn với tỉ lệ cân đối hạt Robusta, cho ra vị ngọt caramel, vị chua dịu và sánh đặc. Để đạt được sự kết hợp này, chúng tôi xay tươi hạt cà phê cho mỗi lần pha.",
                CategoryId=1,
            });
            modelBuilder.Entity<Coffe>().HasData(new Coffe

            {
                Id = 2,
                NameCoffe = "CARAMEL MACCHIATO",
                Price = 55.000,
                Despition = "Vị thơm béo của bọt sữa và sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng, và vị ngọt đậm của sốt caramel.",
                CategoryId = 1,
            });

            modelBuilder.Entity<User>().HasData(new User
            {
               Id=1,
               UserName="trung123",
               Password="trung123",

            });


        }
    } }
