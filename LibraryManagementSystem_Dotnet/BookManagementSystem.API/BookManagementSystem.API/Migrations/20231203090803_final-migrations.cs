using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookManagementSystem.API.Migrations
{
    /// <inheritdoc />
    public partial class finalmigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "3d21b6f8-33e9-4b57-803b-3365ad1ba843" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "43b9afc6-b846-404b-a093-d822f8774974" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "44c80ed4-7cb6-4709-86be-11d2d461f565" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "95cb1e1c-d8b6-45a2-b240-6d211c06fd00", "44c80ed4-7cb6-4709-86be-11d2d461f565" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "7ea617d5-3fe4-4dec-826b-f6438c93eabe" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "faf08129-3bee-4e93-b4ee-37aa810c5ca8" });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7500dd3a-2842-4a30-9e89-a51cd2aa1937"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("79323cfa-70f4-41ca-893d-be990f20a1ef"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("2e3fb2e4-c0c4-499a-822b-147b69bd1a00"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5be0e217-900c-45a3-a98d-afeb6b268d3e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c11f9b68-d1c2-443c-b2f7-4eb92114459f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ca2c4233-7581-49a6-a534-8c2f8d241858"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d21b6f8-33e9-4b57-803b-3365ad1ba843");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43b9afc6-b846-404b-a093-d822f8774974");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44c80ed4-7cb6-4709-86be-11d2d461f565");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ea617d5-3fe4-4dec-826b-f6438c93eabe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faf08129-3bee-4e93-b4ee-37aa810c5ca8");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TokensAvailable", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "688d6b22-2262-4ed4-8fc9-be897a0fa22c", 0, "1fbfe60c-bfd7-4f88-80a7-92ab98620092", "user1@test.com", false, false, null, "User01", "USER1@TEST.COM", "USER1@TEST.COM", "AQAAAAIAAYagAAAAELpUmAlV13tN7GcetVK6z78FZcCWPZhDDRy3H007NOjJh1FJoFsfpdor/XWYq0BFqQ==", null, false, "6d41b23a-6514-41a4-849d-0fe6e1f19df0", 1, false, "user1@test.com" },
                    { "884bb356-0a96-4af5-95d7-f40b734c73cc", 0, "046fe711-09cd-4cca-bcf2-1e7ea2ebadde", "admin@123.com", false, false, null, "Admin123", "ADMIN@123.COM", "ADMIN@123.COM", "AQAAAAIAAYagAAAAECzzKC9zlk61YXhisIK46nUeMWkw2ld0zZ16gvqHYAErhRqGnns8LtJ7GH6FNxPB9g==", null, false, "b4878e75-44e4-4502-83b5-a7dd7e69a1f0", 0, false, "admin@123.com" },
                    { "90bd03d7-5e84-4c3d-b1ca-a7197f814054", 0, "ece92bfc-539b-46bf-b37f-96854da1f508", "amisha1234@gmail.com", false, false, null, "Amisha12", "AMISHA1234@GMAIL.COM", "AMISH1234@GMAIL.COM", "AQAAAAIAAYagAAAAEAeeGpBSxmX0BWtNDr82l7u3KdIe9Os/TJuoDtGi/fNVHNmk85oJRVv99Bz1qz12Xw==", null, false, "2744bc75-bb9e-4345-833a-197e82a7a031", 1, false, "amisha1234" },
                    { "af13deef-a456-4e36-9bdd-b1f2fbedf833", 0, "4f8d3d77-7926-4854-b05e-8e473e3eca85", "user3@test.com", false, false, null, "User03", "USER3@TEST.COM", "USER3@TEST.COM", "AQAAAAIAAYagAAAAECVBCuURJ/iA7HP/C9XquyvbyrLcW0MxHc0rZkQKxj4ZeO3t4bKOHdj5OQkgh84DgA==", null, false, "91693ad4-5acf-4b36-9280-86c06409c548", 1, false, "user3@test.com" },
                    { "ea9007c1-8d1e-4456-b646-9deede968946", 0, "a46a4f7a-104a-4893-b761-d8002b2b193d", "user2@test.com", false, false, null, "User02", "USER2@TEST.COM", "USER2@TEST.COM", "AQAAAAIAAYagAAAAEDiiJwOST6NyNZgBdA2VJJs/ewdFneenu+BGGCWmGeU7ZOMHayTp1acRwrMMVodaxQ==", null, false, "3ff68ff7-f749-409e-9338-2ce2b1eb09be", 1, false, "user2@test.com" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CurrentlyBorrowedByUserId", "Description", "FeaturedImageUrl", "IsAvailable", "LentByUserId", "Name", "Ratings", "UrlHandle" },
                values: new object[,]
                {
                    { new Guid("19df4757-2df5-4999-88d7-94657fc1baec"), "J.K Rolling", null, "Harry Potter and the Sorcerer's Stone, also known as Harry Potter and the Philosopher's Stone outside of the United States, is a fantasy novel written by British author J. K. Rowling. The novel chronicles the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are first-year students at Hogwarts School of Witchcraft and Wizardry. The story covers Harry's first discovery of his magical heritage, his enrollment at Hogwarts, his making of close friends and enemies, and his confrontation with the dark wizard Lord Voldemort. The novel was first published in the United Kingdom by Bloomsbury Ltd. on 26 June 1997.\r\n\r\nA lonely orphan living with his unwelcoming aunt, uncle, and cousin, Harry Potter learns on his eleventh birthday that he is an orphaned wizard and is famous throughout the wizarding world as the boy who survived the attack by Lord Voldemort, a powerful dark wizard who killed Harry's parents in their attempt to thwart his bid for power. Harry is summoned from his life as an unwanted child by his parents' friend Rubeus Hagrid, a giant and Hogwarts' Keeper of Keys and Grounds, who reveals to him that he is a wizard and has been accepted at Hogwarts School of Witchcraft and Wizardry.\r\n\r\nAt Hogwarts, Harry is sorted into Gryffindor House and befriends Ron Weasley and Hermione Granger. Together, they learn about magic, defend themselves from dark creatures, and uncover a plot by Voldemort, who has returned to power and is hiding within the school, to steal the Sorcerer's Stone, a powerful object that would grant him immortality.", "https://images.pexels.com/photos/8391515/pexels-photo-8391515.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", true, "884bb356-0a96-4af5-95d7-f40b734c73cc", "Harry Potter", 0.0, "Harry Potter and the Sorcerer's Stone" },
                    { new Guid("5456af5d-6b4a-4049-8af7-943f58802494"), "Bhagat Singh", null, " Bhagat Singh's Jail Diary is a poignant and thought-provoking collection of writings penned by the Indian revolutionary during his imprisonment in Lahore Central Jail from 1929 to 1931. It offers a glimpse into his mind and soul, revealing his deep love for his country, his unwavering commitment to social justice, and his unwavering belief in the power of revolution.  The diary is a tapestry of personal reflections, political treatises, and literary musings, reflecting Singh's multifaceted personality and his wide-ranging intellectual interests. He delves into topics such as imperialism, capitalism, socialism, atheism, and religion, engaging with the ideas of prominent thinkers like Karl Marx, Vladimir Lenin, and Fyodor Dostoevsky.  Singh's writings are characterized by their clarity, passion, and sincerity. He fearlessly exposes the injustices of British rule in India and the plight of the oppressed masses. He calls for a radical transformation of society, advocating for a classless, egalitarian society based on the principles of socialism and communism.  The Jail Diary is not just a historical document; it is a testament to the indomitable spirit of a young man who dared to challenge the status quo and fight for a better world. It continues to inspire and challenge readers, reminding us of the power of individual action and the importance of fighting for what is right.", "https://m.media-amazon.com/images/I/51h5ch+vZIL.jpg", true, "884bb356-0a96-4af5-95d7-f40b734c73cc", "Jail Diary", 0.0, "Jail Diary By Bhagat Singh" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "UrlHandle" },
                values: new object[,]
                {
                    { new Guid("610a96ad-0682-4f47-a3ed-cd2a0496eb8b"), "Novel", "/Novel" },
                    { new Guid("be0258ac-a27c-4cf8-bfe6-9703b52dead5"), "Others", "/Others" },
                    { new Guid("d85ec9a3-1efa-43f7-93ee-962873268fe5"), "Science Fiction", "Science Fiction" },
                    { new Guid("f088435f-0272-4602-b385-39cec3c7368d"), "Fantasy", "/Fantasy" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "688d6b22-2262-4ed4-8fc9-be897a0fa22c" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "884bb356-0a96-4af5-95d7-f40b734c73cc" },
                    { "95cb1e1c-d8b6-45a2-b240-6d211c06fd00", "884bb356-0a96-4af5-95d7-f40b734c73cc" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "90bd03d7-5e84-4c3d-b1ca-a7197f814054" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "af13deef-a456-4e36-9bdd-b1f2fbedf833" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "ea9007c1-8d1e-4456-b646-9deede968946" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "688d6b22-2262-4ed4-8fc9-be897a0fa22c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "884bb356-0a96-4af5-95d7-f40b734c73cc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "95cb1e1c-d8b6-45a2-b240-6d211c06fd00", "884bb356-0a96-4af5-95d7-f40b734c73cc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "90bd03d7-5e84-4c3d-b1ca-a7197f814054" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "af13deef-a456-4e36-9bdd-b1f2fbedf833" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "ea9007c1-8d1e-4456-b646-9deede968946" });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("19df4757-2df5-4999-88d7-94657fc1baec"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5456af5d-6b4a-4049-8af7-943f58802494"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("610a96ad-0682-4f47-a3ed-cd2a0496eb8b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("be0258ac-a27c-4cf8-bfe6-9703b52dead5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d85ec9a3-1efa-43f7-93ee-962873268fe5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f088435f-0272-4602-b385-39cec3c7368d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "688d6b22-2262-4ed4-8fc9-be897a0fa22c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "884bb356-0a96-4af5-95d7-f40b734c73cc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90bd03d7-5e84-4c3d-b1ca-a7197f814054");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af13deef-a456-4e36-9bdd-b1f2fbedf833");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea9007c1-8d1e-4456-b646-9deede968946");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TokensAvailable", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3d21b6f8-33e9-4b57-803b-3365ad1ba843", 0, "1d493b3b-1704-4017-8519-512b5d39a3a3", "user3@test.com", false, false, null, "User03", "USER3@TEST.COM", "USER3@TEST.COM", "AQAAAAIAAYagAAAAEETePV2n1Ykyus4Twkg0T0GVKDF5y8w25FlkGJ8opVO7zqrXcT6OWOoRaHfCHgYKQQ==", null, false, "1041e324-e8d2-4a33-ac62-e2a4d544ec76", 1, false, "user3@test.com" },
                    { "43b9afc6-b846-404b-a093-d822f8774974", 0, "fa2cff2c-d058-48b6-afd3-ec9064626331", "amisha1234@gmail.com", false, false, null, "Amisha12", "AMISHA1234@GMAIL.COM", "AMISH1234@GMAIL.COM", "AQAAAAIAAYagAAAAEKQm4U6l8UdSG8oMPJhuwtpLFIOiG96ALLZlqP0qt5Gm9zQuNqk9aga1dIA0K9nKAw==", null, false, "ed9bf125-d087-463d-b3ea-9899d8481981", 1, false, "amisha1234" },
                    { "44c80ed4-7cb6-4709-86be-11d2d461f565", 0, "1da28862-49a2-4ce6-9542-03d286b0c836", "admin@test.com", false, false, null, "Admin", "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAIAAYagAAAAEPDYifyqueSbNVBrygPQBLmvU8SlA5rHll3TBT9o8/2l5FJCq0SNrIyexzG/7eFaXQ==", null, false, "4c0e86bf-c64b-4b51-9375-bb115bf26721", 0, false, "admin@test.com" },
                    { "7ea617d5-3fe4-4dec-826b-f6438c93eabe", 0, "bf3e8e29-cbf6-4dbf-a393-1affa3daa3fd", "user1@test.com", false, false, null, "User01", "USER1@TEST.COM", "USER1@TEST.COM", "AQAAAAIAAYagAAAAEHmoJAmEBZjU37ReOsk5Go9SCLCKlfbNRMpDkwdKIJSRoaVcltCy5k1eWxzK/0gSog==", null, false, "a3d1c6a6-02f4-45d2-b9c2-587308932509", 1, false, "user1@test.com" },
                    { "faf08129-3bee-4e93-b4ee-37aa810c5ca8", 0, "16e73479-ecdc-4979-bf71-591bf466dcdd", "user2@test.com", false, false, null, "User02", "USER2@TEST.COM", "USER2@TEST.COM", "AQAAAAIAAYagAAAAEIAsh2TR4wok/SS8cWszN9VRHDJAZBTb9KfAKl4c9GfBW2gdMjUTYZrVJTaYyfwynw==", null, false, "b3ddcf97-531d-4e37-8d8f-9e9e45f560fc", 1, false, "user2@test.com" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CurrentlyBorrowedByUserId", "Description", "FeaturedImageUrl", "IsAvailable", "LentByUserId", "Name", "Ratings", "UrlHandle" },
                values: new object[,]
                {
                    { new Guid("7500dd3a-2842-4a30-9e89-a51cd2aa1937"), "J.K Rolling", null, "Harry Potter and the Sorcerer's Stone, also known as Harry Potter and the Philosopher's Stone outside of the United States, is a fantasy novel written by British author J. K. Rowling. The novel chronicles the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are first-year students at Hogwarts School of Witchcraft and Wizardry. The story covers Harry's first discovery of his magical heritage, his enrollment at Hogwarts, his making of close friends and enemies, and his confrontation with the dark wizard Lord Voldemort. The novel was first published in the United Kingdom by Bloomsbury Ltd. on 26 June 1997.\r\n\r\nA lonely orphan living with his unwelcoming aunt, uncle, and cousin, Harry Potter learns on his eleventh birthday that he is an orphaned wizard and is famous throughout the wizarding world as the boy who survived the attack by Lord Voldemort, a powerful dark wizard who killed Harry's parents in their attempt to thwart his bid for power. Harry is summoned from his life as an unwanted child by his parents' friend Rubeus Hagrid, a giant and Hogwarts' Keeper of Keys and Grounds, who reveals to him that he is a wizard and has been accepted at Hogwarts School of Witchcraft and Wizardry.\r\n\r\nAt Hogwarts, Harry is sorted into Gryffindor House and befriends Ron Weasley and Hermione Granger. Together, they learn about magic, defend themselves from dark creatures, and uncover a plot by Voldemort, who has returned to power and is hiding within the school, to steal the Sorcerer's Stone, a powerful object that would grant him immortality.", "https://images.pexels.com/photos/8391515/pexels-photo-8391515.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", true, "44c80ed4-7cb6-4709-86be-11d2d461f565", "Harry Potter", 0.0, "Harry Potter and the Sorcerer's Stone" },
                    { new Guid("79323cfa-70f4-41ca-893d-be990f20a1ef"), "Bhagat Singh", null, " Bhagat Singh's Jail Diary is a poignant and thought-provoking collection of writings penned by the Indian revolutionary during his imprisonment in Lahore Central Jail from 1929 to 1931. It offers a glimpse into his mind and soul, revealing his deep love for his country, his unwavering commitment to social justice, and his unwavering belief in the power of revolution.  The diary is a tapestry of personal reflections, political treatises, and literary musings, reflecting Singh's multifaceted personality and his wide-ranging intellectual interests. He delves into topics such as imperialism, capitalism, socialism, atheism, and religion, engaging with the ideas of prominent thinkers like Karl Marx, Vladimir Lenin, and Fyodor Dostoevsky.  Singh's writings are characterized by their clarity, passion, and sincerity. He fearlessly exposes the injustices of British rule in India and the plight of the oppressed masses. He calls for a radical transformation of society, advocating for a classless, egalitarian society based on the principles of socialism and communism.  The Jail Diary is not just a historical document; it is a testament to the indomitable spirit of a young man who dared to challenge the status quo and fight for a better world. It continues to inspire and challenge readers, reminding us of the power of individual action and the importance of fighting for what is right.", "https://m.media-amazon.com/images/I/51h5ch+vZIL.jpg", true, "44c80ed4-7cb6-4709-86be-11d2d461f565", "Jail Diary", 0.0, "Jail Diary By Bhagat Singh" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "UrlHandle" },
                values: new object[,]
                {
                    { new Guid("2e3fb2e4-c0c4-499a-822b-147b69bd1a00"), "Fantasy", "/Fantasy" },
                    { new Guid("5be0e217-900c-45a3-a98d-afeb6b268d3e"), "Novel", "/Novel" },
                    { new Guid("c11f9b68-d1c2-443c-b2f7-4eb92114459f"), "Science Fiction", "Science Fiction" },
                    { new Guid("ca2c4233-7581-49a6-a534-8c2f8d241858"), "Others", "/Others" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "3d21b6f8-33e9-4b57-803b-3365ad1ba843" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "43b9afc6-b846-404b-a093-d822f8774974" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "44c80ed4-7cb6-4709-86be-11d2d461f565" },
                    { "95cb1e1c-d8b6-45a2-b240-6d211c06fd00", "44c80ed4-7cb6-4709-86be-11d2d461f565" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "7ea617d5-3fe4-4dec-826b-f6438c93eabe" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "faf08129-3bee-4e93-b4ee-37aa810c5ca8" }
                });
        }
    }
}
