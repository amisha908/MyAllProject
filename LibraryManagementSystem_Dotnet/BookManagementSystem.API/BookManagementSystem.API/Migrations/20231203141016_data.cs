using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookManagementSystem.API.Migrations
{
    /// <inheritdoc />
    public partial class data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "15983743-e924-416a-9026-675aaf22f63d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "47ad4d3a-beef-4908-bec4-182c418d7c88" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "95cb1e1c-d8b6-45a2-b240-6d211c06fd00", "47ad4d3a-beef-4908-bec4-182c418d7c88" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "ca55f33d-720d-43ab-aa0b-be9f197f38fa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "e922f3b5-4c85-495f-be8f-6234353e8ea2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "f22a2102-9b68-4e3c-b0b6-7f0e4af372f3" });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7f28ed0b-3c42-4532-915c-25d15cc31771"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("aba2dc0e-f7a2-4c50-818a-95209a42546c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0bc2dbf9-67a0-4823-95cc-fbbb60375ece"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("13018820-3bbf-4319-8f5e-29d77fd10e88"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("3e1132d1-47a1-4a9a-8f09-636bda82ba79"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6422ae3f-cf41-4a88-a2a7-0581a7d9ac12"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15983743-e924-416a-9026-675aaf22f63d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47ad4d3a-beef-4908-bec4-182c418d7c88");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca55f33d-720d-43ab-aa0b-be9f197f38fa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e922f3b5-4c85-495f-be8f-6234353e8ea2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f22a2102-9b68-4e3c-b0b6-7f0e4af372f3");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "15983743-e924-416a-9026-675aaf22f63d", 0, "380fa105-55f3-465b-b3fa-31a0657b8480", "amisha1234@gmail.com", false, false, null, "Amisha12", "AMISHA1234@GMAIL.COM", "AMISH1234@GMAIL.COM", "AQAAAAIAAYagAAAAEIbFr48EwOF+VHO6Jr0c0RfDgI87KWGVNRazA8ICUEfdrQKFLIxRE4HWvs0eKJxNKg==", null, false, "32777702-bd1e-4962-b1de-c93e65caa5d5", 1, false, "amisha@1234" },
                    { "47ad4d3a-beef-4908-bec4-182c418d7c88", 0, "f71396c1-ac2e-4ef1-8238-00f8663524d2", "admin@123.com", false, false, null, "Admin123", "ADMIN@123.COM", "ADMIN@123.COM", "AQAAAAIAAYagAAAAEI/MtILkCgnkAHlMR2VrEXLDDdhUZcn2wmsL4INmArmI49ZCWXaABPwO3fiUK7YciA==", null, false, "c9980995-4d2e-476c-a1b9-c530122e85c3", 0, false, "admin@123.com" },
                    { "ca55f33d-720d-43ab-aa0b-be9f197f38fa", 0, "6e3b8794-8535-4b90-808e-cae9ce09a44a", "user1@test.com", false, false, null, "User01", "USER1@TEST.COM", "USER1@TEST.COM", "AQAAAAIAAYagAAAAELup1ntyrhfIpo21zccUYPI7ccp3iPjg66cngZPHLp7ZmODY4Hsh4QxRGknBcqYQDw==", null, false, "b6e8af62-5715-4461-a674-e31f22b88aca", 1, false, "user1@test.com" },
                    { "e922f3b5-4c85-495f-be8f-6234353e8ea2", 0, "90ee36d1-0743-4441-bd67-0b096a6f8c58", "user2@test.com", false, false, null, "User02", "USER2@TEST.COM", "USER2@TEST.COM", "AQAAAAIAAYagAAAAEI8/gQc1UMMc6Ke9dutr7D/VfSKpRg8JLIP+DJAPBjtDa+1WjtEp8nGsoAO7drI4yA==", null, false, "e84c461d-6ff9-49ff-b1a1-404b47bcb805", 1, false, "user2@test.com" },
                    { "f22a2102-9b68-4e3c-b0b6-7f0e4af372f3", 0, "e6bc7b98-1363-471b-bb98-8b0a643391a1", "user3@test.com", false, false, null, "User03", "USER3@TEST.COM", "USER3@TEST.COM", "AQAAAAIAAYagAAAAEEHQk0oDSMjc2EuXDfTdoCn/D8yWk/ty2zd9KtoAVXtODfOCInipCyzFgE+Nf0mmQw==", null, false, "dd703ff9-e00a-4aa7-a980-ce5fdc4dbb33", 1, false, "user3@test.com" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CurrentlyBorrowedByUserId", "Description", "FeaturedImageUrl", "IsAvailable", "LentByUserId", "Name", "Ratings", "UrlHandle" },
                values: new object[,]
                {
                    { new Guid("7f28ed0b-3c42-4532-915c-25d15cc31771"), "J.K Rolling", null, "Harry Potter and the Sorcerer's Stone, also known as Harry Potter and the Philosopher's Stone outside of the United States, is a fantasy novel written by British author J. K. Rowling. The novel chronicles the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are first-year students at Hogwarts School of Witchcraft and Wizardry. The story covers Harry's first discovery of his magical heritage, his enrollment at Hogwarts, his making of close friends and enemies, and his confrontation with the dark wizard Lord Voldemort. The novel was first published in the United Kingdom by Bloomsbury Ltd. on 26 June 1997.\r\n\r\nA lonely orphan living with his unwelcoming aunt, uncle, and cousin, Harry Potter learns on his eleventh birthday that he is an orphaned wizard and is famous throughout the wizarding world as the boy who survived the attack by Lord Voldemort, a powerful dark wizard who killed Harry's parents in their attempt to thwart his bid for power. Harry is summoned from his life as an unwanted child by his parents' friend Rubeus Hagrid, a giant and Hogwarts' Keeper of Keys and Grounds, who reveals to him that he is a wizard and has been accepted at Hogwarts School of Witchcraft and Wizardry.\r\n\r\nAt Hogwarts, Harry is sorted into Gryffindor House and befriends Ron Weasley and Hermione Granger. Together, they learn about magic, defend themselves from dark creatures, and uncover a plot by Voldemort, who has returned to power and is hiding within the school, to steal the Sorcerer's Stone, a powerful object that would grant him immortality.", "https://images.pexels.com/photos/8391515/pexels-photo-8391515.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", true, "47ad4d3a-beef-4908-bec4-182c418d7c88", "Harry Potter", 0.0, "Harry Potter and the Sorcerer's Stone" },
                    { new Guid("aba2dc0e-f7a2-4c50-818a-95209a42546c"), "Bhagat Singh", null, " Bhagat Singh's Jail Diary is a poignant and thought-provoking collection of writings penned by the Indian revolutionary during his imprisonment in Lahore Central Jail from 1929 to 1931. It offers a glimpse into his mind and soul, revealing his deep love for his country, his unwavering commitment to social justice, and his unwavering belief in the power of revolution.  The diary is a tapestry of personal reflections, political treatises, and literary musings, reflecting Singh's multifaceted personality and his wide-ranging intellectual interests. He delves into topics such as imperialism, capitalism, socialism, atheism, and religion, engaging with the ideas of prominent thinkers like Karl Marx, Vladimir Lenin, and Fyodor Dostoevsky.  Singh's writings are characterized by their clarity, passion, and sincerity. He fearlessly exposes the injustices of British rule in India and the plight of the oppressed masses. He calls for a radical transformation of society, advocating for a classless, egalitarian society based on the principles of socialism and communism.  The Jail Diary is not just a historical document; it is a testament to the indomitable spirit of a young man who dared to challenge the status quo and fight for a better world. It continues to inspire and challenge readers, reminding us of the power of individual action and the importance of fighting for what is right.", "https://m.media-amazon.com/images/I/51h5ch+vZIL.jpg", true, "47ad4d3a-beef-4908-bec4-182c418d7c88", "Jail Diary", 0.0, "Jail Diary By Bhagat Singh" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "UrlHandle" },
                values: new object[,]
                {
                    { new Guid("0bc2dbf9-67a0-4823-95cc-fbbb60375ece"), "Fantasy", "/Fantasy" },
                    { new Guid("13018820-3bbf-4319-8f5e-29d77fd10e88"), "Others", "/Others" },
                    { new Guid("3e1132d1-47a1-4a9a-8f09-636bda82ba79"), "Novel", "/Novel" },
                    { new Guid("6422ae3f-cf41-4a88-a2a7-0581a7d9ac12"), "Science Fiction", "Science Fiction" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "15983743-e924-416a-9026-675aaf22f63d" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "47ad4d3a-beef-4908-bec4-182c418d7c88" },
                    { "95cb1e1c-d8b6-45a2-b240-6d211c06fd00", "47ad4d3a-beef-4908-bec4-182c418d7c88" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "ca55f33d-720d-43ab-aa0b-be9f197f38fa" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "e922f3b5-4c85-495f-be8f-6234353e8ea2" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "f22a2102-9b68-4e3c-b0b6-7f0e4af372f3" }
                });
        }
    }
}
