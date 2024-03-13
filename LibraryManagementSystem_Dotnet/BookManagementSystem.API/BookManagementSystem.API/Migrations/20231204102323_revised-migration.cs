using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookManagementSystem.API.Migrations
{
    /// <inheritdoc />
    public partial class revisedmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "382ae40e-e244-4efd-b606-35bbcfd98d61" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "95cb1e1c-d8b6-45a2-b240-6d211c06fd00", "382ae40e-e244-4efd-b606-35bbcfd98d61" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "3e027cc4-00a8-44c5-982a-e270b3125367" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "4968333c-8f88-45b3-a236-753db90b6be5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "f28dd2d0-ac5d-4d0c-809f-3a324d055b91" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "f6c703b4-3878-4ffe-8d97-c8b415c9c76a" });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("20d3390d-ad05-48ee-b8ff-889bea79cdf2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c71a7cf3-538b-4776-8b87-b0aa5be87397"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("095204ce-9477-4ac1-b56a-36de3c2d858e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("2491655e-69a3-44cf-a420-6a72e8b39251"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("39ee6cc3-2c19-446e-9c72-17633c646204"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("789a264c-745d-4f31-8f54-35d795da373c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "382ae40e-e244-4efd-b606-35bbcfd98d61");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e027cc4-00a8-44c5-982a-e270b3125367");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4968333c-8f88-45b3-a236-753db90b6be5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f28dd2d0-ac5d-4d0c-809f-3a324d055b91");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6c703b4-3878-4ffe-8d97-c8b415c9c76a");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TokensAvailable", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3db2d1d3-d595-421d-9f62-5973aafcb2e7", 0, "2a206bb3-c6f8-4bd7-b7f8-837707d994a8", "user3@test.com", false, false, null, "User03", "USER3@TEST.COM", "USER3@TEST.COM", "AQAAAAIAAYagAAAAED5plgBAMnuoVB/v9oe8X1k79qWRkX08at40XurTYtow/6GHe7yj7w4UtXcu5OMFvQ==", null, false, "323ac729-db80-42c9-9185-f19a526c5460", 1, false, "user3@test.com" },
                    { "5a4bb6b2-d83f-4235-bc2c-ddebd71685c6", 0, "d3867f3e-cf01-41a6-9d34-3cf0c3096007", "amisha@test.com", false, false, null, "Amisha", "AMISHA@TEST.COM", "AMISHA@TEST.COM", "AQAAAAIAAYagAAAAENZJ3BXMrBjK3oGvgYzNoa514xrv3qrQ4HGgAXrlLQWypwrIDBNz6XKBwoYAwT5Dfg==", null, false, "a5b6a481-e4f8-4905-b7fe-c371074a0411", 1, false, "amisha@test.com" },
                    { "9fc6cbc1-880c-4d3a-9b47-323caa694751", 0, "56a367a1-6884-4279-b0f0-39ca1f3609d4", "admin@123.com", false, false, null, "Admin123", "ADMIN@123.COM", "ADMIN@123.COM", "AQAAAAIAAYagAAAAEGFnW2Ay5ERZCT4eCder7omx+w1wxaMqeDfithv12wD0HOM8efOvGx4WE7bU0/A2pA==", null, false, "65f65885-d0ef-41d8-83b1-2793f05ee918", 0, false, "admin@123.com" },
                    { "bc63ba64-0945-4a63-8237-075242ca235d", 0, "09e22560-dfa5-4220-bf95-ce4a510c29bc", "amisha1234@gmail.com", false, false, null, "Amisha12", "AMISHA1234@GMAIL.COM", "AMISH1234@GMAIL.COM", "AQAAAAIAAYagAAAAEE7wlSakHLXf+8PGKMqdAiHXDoi3e9CR6nz5viy/zDRlgjo/rQnWinE5v6xh6X/hfg==", null, false, "36fb69b9-2d91-4b05-a55a-1df7227bfe29", 1, false, "amisha@1234" },
                    { "fd94d74b-fae4-4813-b2e5-e218898e7813", 0, "1875fd2f-d2d9-4f1d-83da-de1862fbb202", "user1@test.com", false, false, null, "User01", "USER1@TEST.COM", "USER1@TEST.COM", "AQAAAAIAAYagAAAAELcXA6+xID4CadwY0cJgdKb1K5MHaxglhuIXNFr3vjFCk0VEEeI4qNMs44+LJeGkQw==", null, false, "c1c1dc04-263d-41ea-a736-b6232a58c3cb", 1, false, "user1@test.com" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "UrlHandle" },
                values: new object[,]
                {
                    { new Guid("476f2b86-37c2-4cd5-97f8-d1ef14eb23f2"), "Novel", "/Novel" },
                    { new Guid("56db2a2c-cc51-4a4c-9db2-cadf0f1750bd"), "Science Fiction", "Science Fiction" },
                    { new Guid("b2cc93b6-4ebe-4f73-bc4b-2ea55e6ad1bd"), "Fantasy", "/Fantasy" },
                    { new Guid("c199371a-fb18-4d4d-9646-b50b8a07f179"), "Others", "/Others" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "3db2d1d3-d595-421d-9f62-5973aafcb2e7" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "5a4bb6b2-d83f-4235-bc2c-ddebd71685c6" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "9fc6cbc1-880c-4d3a-9b47-323caa694751" },
                    { "95cb1e1c-d8b6-45a2-b240-6d211c06fd00", "9fc6cbc1-880c-4d3a-9b47-323caa694751" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "bc63ba64-0945-4a63-8237-075242ca235d" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "fd94d74b-fae4-4813-b2e5-e218898e7813" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "3db2d1d3-d595-421d-9f62-5973aafcb2e7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "5a4bb6b2-d83f-4235-bc2c-ddebd71685c6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "9fc6cbc1-880c-4d3a-9b47-323caa694751" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "95cb1e1c-d8b6-45a2-b240-6d211c06fd00", "9fc6cbc1-880c-4d3a-9b47-323caa694751" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "bc63ba64-0945-4a63-8237-075242ca235d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "fd94d74b-fae4-4813-b2e5-e218898e7813" });

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("476f2b86-37c2-4cd5-97f8-d1ef14eb23f2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("56db2a2c-cc51-4a4c-9db2-cadf0f1750bd"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b2cc93b6-4ebe-4f73-bc4b-2ea55e6ad1bd"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c199371a-fb18-4d4d-9646-b50b8a07f179"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3db2d1d3-d595-421d-9f62-5973aafcb2e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a4bb6b2-d83f-4235-bc2c-ddebd71685c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9fc6cbc1-880c-4d3a-9b47-323caa694751");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc63ba64-0945-4a63-8237-075242ca235d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd94d74b-fae4-4813-b2e5-e218898e7813");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TokensAvailable", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "382ae40e-e244-4efd-b606-35bbcfd98d61", 0, "1cd8c0cc-32a3-4383-a6f5-cc770e6e1a9e", "admin@123.com", false, false, null, "Admin123", "ADMIN@123.COM", "ADMIN@123.COM", "AQAAAAIAAYagAAAAEO8dCbw16cbSqYfZMSOpP40WqwAgbYY1z9EwlH0aRwZrF6Jyfzc7xeTVI+RMjtj7hg==", null, false, "ed691018-7549-4488-8e0e-0c1e9ec86722", 0, false, "admin@123.com" },
                    { "3e027cc4-00a8-44c5-982a-e270b3125367", 0, "4970763a-8910-4b7c-a48d-c6b4420ecc1a", "user2@test.com", false, false, null, "User02", "USER2@TEST.COM", "USER2@TEST.COM", "AQAAAAIAAYagAAAAECTsSJwuEwIuE1omRosjclo1lam6rYnpQnIBEChwon8qhbeHne4zPfo+sZ+RM6KM4w==", null, false, "b84b7e2e-283a-4ac5-9cf5-b95aa1e8d719", 1, false, "user2@test.com" },
                    { "4968333c-8f88-45b3-a236-753db90b6be5", 0, "b08924c4-ace6-4e8e-b413-62a54ffe3eba", "user1@test.com", false, false, null, "User01", "USER1@TEST.COM", "USER1@TEST.COM", "AQAAAAIAAYagAAAAEFO2CtHva72ccNmuCvx0OvmT0q5aW6ZQnEAJWoavGVwFvtGolRH4mSO+k3nzTLHeew==", null, false, "ef61ae36-f910-49e0-95eb-87e822989ef0", 1, false, "user1@test.com" },
                    { "f28dd2d0-ac5d-4d0c-809f-3a324d055b91", 0, "3b6fd552-c60c-416a-a6d0-956d20982723", "user3@test.com", false, false, null, "User03", "USER3@TEST.COM", "USER3@TEST.COM", "AQAAAAIAAYagAAAAEFsdvBBlOd+4+e/2QbCla6bT9DrpKpnsV5L8FPCcRZUn/dldFx2qBUMiDM1YRDuRuA==", null, false, "ba62e8e8-ae1a-40bd-aa59-f4382256c7ce", 1, false, "user3@test.com" },
                    { "f6c703b4-3878-4ffe-8d97-c8b415c9c76a", 0, "3c1e147a-5193-4434-9995-b9bf02c05ed4", "amisha1234@gmail.com", false, false, null, "Amisha12", "AMISHA1234@GMAIL.COM", "AMISH1234@GMAIL.COM", "AQAAAAIAAYagAAAAEIbAdl6OGZc7dkfq3xxCPvZvs/f7/CR4DhvFP1RVy8Cvr5NRyolsjLyZWW2kM0VzUQ==", null, false, "b67560bc-7c11-4930-935f-b2316ef14426", 1, false, "amisha@1234" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CurrentlyBorrowedByUserId", "Description", "FeaturedImageUrl", "IsAvailable", "LentByUserId", "Name", "Ratings", "UrlHandle" },
                values: new object[,]
                {
                    { new Guid("20d3390d-ad05-48ee-b8ff-889bea79cdf2"), "Bhagat Singh", null, " Bhagat Singh's Jail Diary is a poignant and thought-provoking collection of writings penned by the Indian revolutionary during his imprisonment in Lahore Central Jail from 1929 to 1931. It offers a glimpse into his mind and soul, revealing his deep love for his country, his unwavering commitment to social justice, and his unwavering belief in the power of revolution.  The diary is a tapestry of personal reflections, political treatises, and literary musings, reflecting Singh's multifaceted personality and his wide-ranging intellectual interests. He delves into topics such as imperialism, capitalism, socialism, atheism, and religion, engaging with the ideas of prominent thinkers like Karl Marx, Vladimir Lenin, and Fyodor Dostoevsky.  Singh's writings are characterized by their clarity, passion, and sincerity. He fearlessly exposes the injustices of British rule in India and the plight of the oppressed masses. He calls for a radical transformation of society, advocating for a classless, egalitarian society based on the principles of socialism and communism.  The Jail Diary is not just a historical document; it is a testament to the indomitable spirit of a young man who dared to challenge the status quo and fight for a better world. It continues to inspire and challenge readers, reminding us of the power of individual action and the importance of fighting for what is right.", "", true, "382ae40e-e244-4efd-b606-35bbcfd98d61", "Jail Diary", 0.0, "Jail Diary By Bhagat Singh" },
                    { new Guid("c71a7cf3-538b-4776-8b87-b0aa5be87397"), "J.K Rolling", null, "Harry Potter and the Sorcerer's Stone, also known as Harry Potter and the Philosopher's Stone outside of the United States, is a fantasy novel written by British author J. K. Rowling. The novel chronicles the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are first-year students at Hogwarts School of Witchcraft and Wizardry. The story covers Harry's first discovery of his magical heritage, his enrollment at Hogwarts, his making of close friends and enemies, and his confrontation with the dark wizard Lord Voldemort. The novel was first published in the United Kingdom by Bloomsbury Ltd. on 26 June 1997.\r\n\r\nA lonely orphan living with his unwelcoming aunt, uncle, and cousin, Harry Potter learns on his eleventh birthday that he is an orphaned wizard and is famous throughout the wizarding world as the boy who survived the attack by Lord Voldemort, a powerful dark wizard who killed Harry's parents in their attempt to thwart his bid for power. Harry is summoned from his life as an unwanted child by his parents' friend Rubeus Hagrid, a giant and Hogwarts' Keeper of Keys and Grounds, who reveals to him that he is a wizard and has been accepted at Hogwarts School of Witchcraft and Wizardry.\r\n\r\nAt Hogwarts, Harry is sorted into Gryffindor House and befriends Ron Weasley and Hermione Granger. Together, they learn about magic, defend themselves from dark creatures, and uncover a plot by Voldemort, who has returned to power and is hiding within the school, to steal the Sorcerer's Stone, a powerful object that would grant him immortality.", "", true, "382ae40e-e244-4efd-b606-35bbcfd98d61", "Harry Potter", 0.0, "Harry Potter and the Sorcerer's Stone" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "UrlHandle" },
                values: new object[,]
                {
                    { new Guid("095204ce-9477-4ac1-b56a-36de3c2d858e"), "Science Fiction", "Science Fiction" },
                    { new Guid("2491655e-69a3-44cf-a420-6a72e8b39251"), "Fantasy", "/Fantasy" },
                    { new Guid("39ee6cc3-2c19-446e-9c72-17633c646204"), "Others", "/Others" },
                    { new Guid("789a264c-745d-4f31-8f54-35d795da373c"), "Novel", "/Novel" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "382ae40e-e244-4efd-b606-35bbcfd98d61" },
                    { "95cb1e1c-d8b6-45a2-b240-6d211c06fd00", "382ae40e-e244-4efd-b606-35bbcfd98d61" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "3e027cc4-00a8-44c5-982a-e270b3125367" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "4968333c-8f88-45b3-a236-753db90b6be5" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "f28dd2d0-ac5d-4d0c-809f-3a324d055b91" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "f6c703b4-3878-4ffe-8d97-c8b415c9c76a" }
                });
        }
    }
}
