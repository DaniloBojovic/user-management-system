using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Models;

namespace UserManagementSystem.Context
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserContext(DbContextOptions<UserContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = Guid.Parse("493c3228-3444-4a49-9cc0-e8532edc59b2"),
                    FirstName = "Josh",
                    LastName = "Waitzkin",
                    Username = "jwaitz",
                    Password = "xf0JYDbALF",
                    Email = "jwaitz@rambler.ru",
                    Status = "active",
                    IsAdmin = true
                },
                new User
                {
                    Id = Guid.Parse("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                    FirstName = "Cal",
                    LastName = " Newport",
                    Username = "cal",
                    Password = "DOIm5h",
                    Email = "call@yolasite.com",
                    Status = "active",
                    IsAdmin = true
                },
                new User
                {
                    Id = Guid.Parse("494c3228-3444-4a49-9cc0-e8532edc59b2"),
                    FirstName = "Roger",
                    LastName = "Velichkovic",
                    Username = "veli099",
                    Password = "v05mT7Xz4",
                    Email = "cnussgen2@tmall.com",
                    Status = "inactive",
                    IsAdmin = true
                },
                new User
                {
                    Id = Guid.Parse("d3e757a9-5850-4625-abb8-c69aed20ffbe"),
                    FirstName = "Felipe",
                    LastName = "Verna",
                    Username = "verna",
                    Password = "v05mT7Xz43",
                    Email = "cnussgen2@tmall.com",
                    Status = "inactive",
                    IsAdmin = false
                },
                new User
                {
                    Id = Guid.Parse("79ac0db0-d44c-4c06-94ac-2d130b193542"),
                    FirstName = "Keelby",
                    LastName = " Warnals",
                    Username = "wwyord",
                    Password = "v05dasdmT7Xz43",
                    Email = "warnall@tmall.com",
                    Status = "active",
                    IsAdmin = false

                },
                new User
                {
                    Id = Guid.Parse("7cfa6f3f-2384-467c-b802-ea0188a375fd"),
                    FirstName = "Connor",
                    LastName = "Cockerill",
                    Username = "wwyord",
                    Password = "8VSTlTbA",
                    Email = "connnorwannabe@tmall.com",
                    Status = "active",
                    IsAdmin = true
                },
                new User
                {
                    Id = Guid.Parse("e502b86f-542a-4cc7-ba23-218d1ff622e5"),
                    FirstName = "Sterling",
                    LastName = "Castelli",
                    Username = "ssssterling",
                    Password = "ssssterling32312321",
                    Email = "cast@tmall.com",
                    Status = "active",
                    IsAdmin = true
                },
                new User
                {
                    Id = Guid.Parse("f5891e36-4d39-4da3-82d5-2f02bb156cdd"),
                    FirstName = "Ailsun",
                    LastName = " Agutter",
                    Username = "ag342",
                    Password = "123456",
                    Email = "ag342@tmall.com",
                    Status = "active",
                    IsAdmin = false
                },
                new User
                {
                    Id = Guid.Parse("4dd40884-e54b-41bb-93a7-13e35710debc"),
                    FirstName = "Bob",
                    LastName = "Baalham",
                    Username = "bobby76",
                    Password = "O2kIiMy7",
                    Email = "bobby76@tmall.com",
                    Status = "active",
                    IsAdmin = false
                },
                new User
                {
                    Id = Guid.Parse("187f09fe-847f-4167-8798-fb6b646f1712"),
                    FirstName = "Will",
                    LastName = "Wimsett",
                    Username = "willdewill",
                    Password = "ZG7AZi",
                    Email = "willdewill@tmall.com",
                    Status = "active",
                    IsAdmin = true
                },
                new User
                {
                    Id = Guid.Parse("e3852ef6-1655-4f43-b3cd-79d6616552ff"),
                    FirstName = "Saraann",
                    LastName = " De Biaggi",
                    Username = "Biaggi23",
                    Password = "m80JXxgWb",
                    Email = "biaggi23@tmall.com",
                    Status = "active",
                    IsAdmin = true
                },
                new User
                {
                    Id = Guid.Parse("fe132df5-8293-48e8-8fc6-79b79332e2c4"),
                    FirstName = "Maren",
                    LastName = "MacConchie",
                    Username = "MacConchie34",
                    Password = "XFtOsOHaeF",
                    Email = "maren@tmall.com",
                    Status = "inactive",
                    IsAdmin = true
                },
                 new User
                 {
                     Id = Guid.Parse("374793ec-aeae-4013-8b72-6c48690286af"),
                     FirstName = "Savina",
                     LastName = " Spriddle",
                     Username = "savinas",
                     Password = "9y3m9I",
                     Email = "savinas@tmall.com",
                     Status = "inactive",
                     IsAdmin = false
                 },
                new User
                {
                    Id = Guid.Parse("198139bf-de0f-4c78-9a45-ec66df49413c"),
                    FirstName = "Hedwiga",
                    LastName = "Hillatt",
                    Username = "hillhed",
                    Password = "ued8qu4Y",
                    Email = "hillhed@tmall.com",
                    Status = "active",
                    IsAdmin = true
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
