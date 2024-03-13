using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookManagementSystem.API.Migrations
{
    /// <inheritdoc />
    public partial class finalmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "10c2a62a-8f8a-4a98-b34e-656da1a70530" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "95cb1e1c-d8b6-45a2-b240-6d211c06fd00", "10c2a62a-8f8a-4a98-b34e-656da1a70530" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "45c4513f-3bd7-4f8d-9a7d-ee1a273a6ffc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "62b543d9-3eb7-4101-9674-04e335780403" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "93b51cc8-16db-4133-a1ec-401d34255be9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "d425aad4-ef5f-4fad-a90c-1ff6acefe4b0" });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7dd83381-0938-4366-80aa-318cb4b162ed"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e6366913-5acf-401b-88aa-ecfca7df7e6c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("546090a5-3c3e-4bbd-891b-6e1bea45d1fc"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("95f34b72-b7b9-4323-8185-2461818b4637"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ad28354b-50d3-48ec-a926-70651c094d62"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d16a8f36-741a-46b9-a6f9-93e24577cf5b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10c2a62a-8f8a-4a98-b34e-656da1a70530");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45c4513f-3bd7-4f8d-9a7d-ee1a273a6ffc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62b543d9-3eb7-4101-9674-04e335780403");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93b51cc8-16db-4133-a1ec-401d34255be9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d425aad4-ef5f-4fad-a90c-1ff6acefe4b0");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "10c2a62a-8f8a-4a98-b34e-656da1a70530", 0, "9e2c78ed-e1ed-4883-90bf-c3d9d0bedb8f", "admin@test.com", false, false, null, "Admin", "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAIAAYagAAAAEIy2FfgoUheBGNzM5aU5xWNIg/asN7fCpvzuEOsCxYQ9TmQt+jZg3VMrVEAC9qeIFg==", null, false, "2f81c850-c8e5-4252-802f-eb661783f9af", 0, false, "admin@test.com" },
                    { "45c4513f-3bd7-4f8d-9a7d-ee1a273a6ffc", 0, "fbbc6d72-2397-4a79-97b8-fa88cb8348e1", "user2@test.com", false, false, null, "User02", "USER2@TEST.COM", "USER2@TEST.COM", "AQAAAAIAAYagAAAAECbDh4Yx1XRW0NN0Ev7JMCX40TBrPEqzc9QRvaUzgY/H+xOUrNoDExNy6B2L5A5wXg==", null, false, "41f64659-75ec-43d9-a475-1c081207dc7f", 1, false, "user2@test.com" },
                    { "62b543d9-3eb7-4101-9674-04e335780403", 0, "4f9f9d55-f599-421e-8fc5-3c6bd2ff3563", "user1@test.com", false, false, null, "User01", "USER1@TEST.COM", "USER1@TEST.COM", "AQAAAAIAAYagAAAAEBY5c6X/JUiBkFKBLq5rqmy+DmM93aqxscXj0vmZI+7Z/JSJPUEGkQu/tkyoj130kQ==", null, false, "ee2cf2b3-b3df-4b2f-835a-aa8a746a8081", 1, false, "user1@test.com" },
                    { "93b51cc8-16db-4133-a1ec-401d34255be9", 0, "f897703a-e03e-4f96-bee0-d72ee790e54b", "amisha123@gmail.com", false, false, null, "Amisha", "AMISHA123@GMAIL.COM", "AMISH123@GMAIL.COM", "AQAAAAIAAYagAAAAEB+W1Iw7R3r+nfXzy6SlLQN9oe8F2pnHzo66OSUODOCUbtOJjmaDX+TE3/wc9pdjCQ==", null, false, "d8fa25d3-54be-4523-91b7-640a7c205828", 1, false, "amisha123" },
                    { "d425aad4-ef5f-4fad-a90c-1ff6acefe4b0", 0, "b475ae2f-2bae-4376-b223-eb356d055a04", "user3@test.com", false, false, null, "User03", "USER3@TEST.COM", "USER3@TEST.COM", "AQAAAAIAAYagAAAAEIoku4Lc2qOnoN1CVvDHMKVqhVBCvUpj0hKrce+qXWDo5i9H9RsxsOsj+7xMu8ceqA==", null, false, "921b8e27-f383-42f6-8635-2146a267c270", 1, false, "user3@test.com" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CurrentlyBorrowedByUserId", "Description", "FeaturedImageUrl", "IsAvailable", "LentByUserId", "Name", "Ratings", "UrlHandle" },
                values: new object[,]
                {
                    { new Guid("7dd83381-0938-4366-80aa-318cb4b162ed"), "J.K Rolling", null, "Harry Potter and the Sorcerer's Stone, also known as Harry Potter and the Philosopher's Stone outside of the United States, is a fantasy novel written by British author J. K. Rowling. The novel chronicles the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are first-year students at Hogwarts School of Witchcraft and Wizardry. The story covers Harry's first discovery of his magical heritage, his enrollment at Hogwarts, his making of close friends and enemies, and his confrontation with the dark wizard Lord Voldemort. The novel was first published in the United Kingdom by Bloomsbury Ltd. on 26 June 1997.\r\n\r\nA lonely orphan living with his unwelcoming aunt, uncle, and cousin, Harry Potter learns on his eleventh birthday that he is an orphaned wizard and is famous throughout the wizarding world as the boy who survived the attack by Lord Voldemort, a powerful dark wizard who killed Harry's parents in their attempt to thwart his bid for power. Harry is summoned from his life as an unwanted child by his parents' friend Rubeus Hagrid, a giant and Hogwarts' Keeper of Keys and Grounds, who reveals to him that he is a wizard and has been accepted at Hogwarts School of Witchcraft and Wizardry.\r\n\r\nAt Hogwarts, Harry is sorted into Gryffindor House and befriends Ron Weasley and Hermione Granger. Together, they learn about magic, defend themselves from dark creatures, and uncover a plot by Voldemort, who has returned to power and is hiding within the school, to steal the Sorcerer's Stone, a powerful object that would grant him immortality.", "https://images.pexels.com/photos/8391515/pexels-photo-8391515.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", true, "10c2a62a-8f8a-4a98-b34e-656da1a70530", "Harry Potter", 0.0, "Harry Potter and the Sorcerer's Stone" },
                    { new Guid("e6366913-5acf-401b-88aa-ecfca7df7e6c"), "Bhagat Singh", null, " Bhagat Singh's Jail Diary is a poignant and thought-provoking collection of writings penned by the Indian revolutionary during his imprisonment in Lahore Central Jail from 1929 to 1931. It offers a glimpse into his mind and soul, revealing his deep love for his country, his unwavering commitment to social justice, and his unwavering belief in the power of revolution.  The diary is a tapestry of personal reflections, political treatises, and literary musings, reflecting Singh's multifaceted personality and his wide-ranging intellectual interests. He delves into topics such as imperialism, capitalism, socialism, atheism, and religion, engaging with the ideas of prominent thinkers like Karl Marx, Vladimir Lenin, and Fyodor Dostoevsky.  Singh's writings are characterized by their clarity, passion, and sincerity. He fearlessly exposes the injustices of British rule in India and the plight of the oppressed masses. He calls for a radical transformation of society, advocating for a classless, egalitarian society based on the principles of socialism and communism.  The Jail Diary is not just a historical document; it is a testament to the indomitable spirit of a young man who dared to challenge the status quo and fight for a better world. It continues to inspire and challenge readers, reminding us of the power of individual action and the importance of fighting for what is right.", "https://m.media-amazon.com/images/I/51h5ch+vZIL.jpg", true, "10c2a62a-8f8a-4a98-b34e-656da1a70530", "Jail Diary", 0.0, "Jail Diary By Bhagat Singh" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "UrlHandle" },
                values: new object[,]
                {
                    { new Guid("546090a5-3c3e-4bbd-891b-6e1bea45d1fc"), "Fantasy", "/Fantasy" },
                    { new Guid("95f34b72-b7b9-4323-8185-2461818b4637"), "Science Fiction", "Science Fiction" },
                    { new Guid("ad28354b-50d3-48ec-a926-70651c094d62"), "Others", "/Others" },
                    { new Guid("d16a8f36-741a-46b9-a6f9-93e24577cf5b"), "Novel", "/Novel" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "10c2a62a-8f8a-4a98-b34e-656da1a70530" },
                    { "95cb1e1c-d8b6-45a2-b240-6d211c06fd00", "10c2a62a-8f8a-4a98-b34e-656da1a70530" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "45c4513f-3bd7-4f8d-9a7d-ee1a273a6ffc" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "62b543d9-3eb7-4101-9674-04e335780403" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "93b51cc8-16db-4133-a1ec-401d34255be9" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "d425aad4-ef5f-4fad-a90c-1ff6acefe4b0" }
                });
        }
    }
}
