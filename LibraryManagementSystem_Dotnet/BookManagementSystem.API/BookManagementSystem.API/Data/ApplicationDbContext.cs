using BookManagementSystem.API.Models.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Reflection.Emit;

namespace BookManagementSystem.API.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<BookImage> BookImages { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            var userID1 = Guid.NewGuid().ToString();
            var userID2 = Guid.NewGuid().ToString();
            var userID3 = Guid.NewGuid().ToString();
            var userID4 = Guid.NewGuid().ToString();
            var userID5 = Guid.NewGuid().ToString();

            var hasher = new PasswordHasher<ApplicationUser>();

            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = userID1,
                    Name = "Admin123",
                    UserName = "admin@123.com",
                    Email = "admin@123.com",
                    NormalizedEmail = "admin@123.com".ToUpper(),
                    NormalizedUserName = "admin@123.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "Admin@123")
                },
                new ApplicationUser
                {
                    Id = userID2,
                    Name = "Amisha12",
                    TokensAvailable = 1,
                    UserName = "amisha@1234",
                    Email = "amisha1234@gmail.com",
                    NormalizedEmail = "amisha1234@gmail.com".ToUpper(),
                    NormalizedUserName = "amish1234@gmail.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "password")
                },
                new ApplicationUser
                {
                    Id = userID3,
                    Name = "User01",
                    TokensAvailable = 1,
                    UserName = "user1@test.com",
                    Email = "user1@test.com",
                    NormalizedEmail = "user1@test.com".ToUpper(),
                    NormalizedUserName = "user1@test.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "user1@123")
                },
                new ApplicationUser
                {
                    Id = userID4,
                    Name = "Amisha",
                    TokensAvailable = 1,
                    UserName = "amisha@test.com",
                    Email = "amisha@test.com",
                    NormalizedEmail = "amisha@test.com".ToUpper(),
                    NormalizedUserName = "amisha@test.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "amisha@123")
                },
                new ApplicationUser
                {
                    Id = userID5,
                    Name = "User03",
                    TokensAvailable = 1,
                    UserName = "user3@test.com",
                    Email = "user3@test.com",
                    NormalizedEmail = "user3@test.com".ToUpper(),
                    NormalizedUserName = "user3@test.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "user3@123")
                }
            ); 

           // var bookID1 = Guid.NewGuid();
           // var bookID2 = Guid.NewGuid();

            //modelBuilder.Entity<Book>().HasData(
              //  new Book
               // {
                //    Id = bookID1,
                //    Name = "Harry Potter",
                //    Author = "J.K Rolling",
                //    Description = "Harry Potter and the Sorcerer's Stone, also known as Harry Potter and the Philosopher's Stone outside of the United States," +
                //    " is a fantasy novel written by British author J. K. Rowling. The novel chronicles the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley," +
                //    " all of whom are first-year students at Hogwarts School of Witchcraft and Wizardry. The story covers Harry's first discovery of his magical heritage, his enrollment at Hogwarts," +
                //    " his making of close friends and enemies, and his confrontation with the dark wizard Lord Voldemort. The novel was first published in the United Kingdom by Bloomsbury Ltd. on 26 June 1997.\r\n\r\nA lonely orphan living with his unwelcoming aunt, uncle, " +
                //    "and cousin, Harry Potter learns on his eleventh birthday that he is an orphaned wizard and is famous throughout the wizarding world as the boy who survived the attack by Lord Voldemort, a powerful dark wizard who killed Harry's parents in their attempt to thwart his bid for power. " +
                //    "Harry is summoned from his life as an unwanted child by his parents' friend Rubeus Hagrid, a giant and Hogwarts' Keeper of Keys and Grounds, who reveals to him that he is a wizard and has been accepted at Hogwarts School of Witchcraft and Wizardry.\r\n\r\nAt Hogwarts, " +
                //    "Harry is sorted into Gryffindor House and befriends Ron Weasley and Hermione Granger. Together, they learn about magic, defend themselves from dark creatures, and uncover a plot by Voldemort, who has returned to power and is hiding within the school, to steal the Sorcerer's Stone, " +
                //    "a powerful object that would grant him immortality.",
                //    UrlHandle = "Harry Potter and the Sorcerer's Stone",
                //    IsAvailable = true,
                //    FeaturedImageUrl = "",
                //    LentByUserId = userID1
               // }//,
                //new Book
                //{
                //    Id = bookID2,
                //    Name = "Jail Diary",
                //    Author = "Bhagat Singh",
                //    Description = " Bhagat Singh's Jail Diary is a poignant and thought-provoking collection of writings penned by the Indian revolutionary during his imprisonment in Lahore Central Jail from 1929 to 1931. It offers a glimpse into his mind and soul," +
                //    " revealing his deep love for his country, his unwavering commitment to social justice, and his unwavering belief in the power of revolution.  The diary is a tapestry of personal reflections, political treatises, and literary musings, reflecting Singh's multifaceted personality and his wide-ranging intellectual interests." +
                //    " He delves into topics such as imperialism, capitalism, socialism, atheism, and religion, engaging with the ideas of prominent thinkers like Karl Marx, Vladimir Lenin, and Fyodor Dostoevsky.  Singh's writings are characterized by their clarity, passion, and sincerity." +
                //    " He fearlessly exposes the injustices of British rule in India and the plight of the oppressed masses. He calls for a radical transformation of society, advocating for a classless, egalitarian society based on the principles of socialism and communism. " +
                //    " The Jail Diary is not just a historical document; it is a testament to the indomitable spirit of a young man who dared to challenge the status quo and fight for a better world. It continues to inspire and challenge readers, reminding us of the power of individual action and the importance of fighting for what is right.",
                //    UrlHandle = "Jail Diary By Bhagat Singh",
                //    IsAvailable = true,
                //    FeaturedImageUrl = "",
                //    LentByUserId = userID1
                //}
             //);

            var genreID1 = Guid.NewGuid();
            var genreID2 = Guid.NewGuid();
            var genreID3 = Guid.NewGuid();
            var genreID4 = Guid.NewGuid();

            modelBuilder.Entity<Genre>().HasData(
                new Genre
                {
                    Id = genreID1,
                    Name = "Fantasy",
                    UrlHandle = "/Fantasy"
                },
                new Genre
                {
                    Id = genreID2,
                    Name = "Novel",
                    UrlHandle = "/Novel"
                },
                 new Genre
                 {
                     Id = genreID3,
                     Name = "Science Fiction",
                     UrlHandle = "Science Fiction"
                 },
                 new Genre
                 {
                     Id = genreID4,
                     Name = "Others",
                     UrlHandle = "/Others"
                 }
             );


            var readerRoleId = "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1";
            var writerRoleId = "95cb1e1c-d8b6-45a2-b240-6d211c06fd00";

            var roles = new List<IdentityRole>
            {
                new IdentityRole()
                {
                    Id = readerRoleId,
                    Name = "Reader",
                    NormalizedName = "Reader".ToUpper(),
                    ConcurrencyStamp = readerRoleId
                },
                new IdentityRole()
                {
                    Id = writerRoleId,
                    Name  = "Writer",
                    NormalizedName = "Writer".ToUpper(),
                    ConcurrencyStamp = writerRoleId
                }
            };

            modelBuilder.Entity<IdentityRole>().HasData(roles);

            var assignRoles = new List<IdentityUserRole<string>>()
            {
                new()
                {
                    UserId = userID1,
                    RoleId = readerRoleId
                },
                new()
                {
                    UserId = userID1,
                    RoleId = writerRoleId
                },
                new()
                {
                    UserId = userID2,
                    RoleId = readerRoleId
                },
                new()
                {
                    UserId = userID3,
                    RoleId = readerRoleId
                },
                new()
                {
                    UserId = userID4,
                    RoleId = readerRoleId
                },
                new()
                {
                    UserId = userID5,
                    RoleId = readerRoleId
                }
            };

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(assignRoles);
        }

    }
}
