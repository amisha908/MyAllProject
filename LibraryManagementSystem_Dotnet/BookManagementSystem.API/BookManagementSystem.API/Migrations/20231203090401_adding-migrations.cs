using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookManagementSystem.API.Migrations
{
    /// <inheritdoc />
    public partial class addingmigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "02ccf2e9-f1b2-4945-ae61-6a8b120e2375" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "435a6274-6ea1-4f2a-b202-5c23af9d7127" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "4d293ac5-4a19-4694-8274-e9081f1aa899" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "adf7dec8-c439-4d1e-b71e-4eeffb9a7af9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "95cb1e1c-d8b6-45a2-b240-6d211c06fd00", "adf7dec8-c439-4d1e-b71e-4eeffb9a7af9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "c40a8ca1-3b33-4242-a4c1-8ebd77a26dad" });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0f4461bb-8066-43ec-b250-9d721436fde0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("32769abb-94ae-4577-91c5-db857e13810d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4f51de1c-4b16-456b-aa60-8ad0f45a37b8"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4f6de814-a6fd-4561-b807-06f4922bfa97"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("54007cfd-68de-4dcb-84e5-e96f4b60e91f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("dffb2735-2de2-46d8-b957-f986cdb4f08f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02ccf2e9-f1b2-4945-ae61-6a8b120e2375");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "435a6274-6ea1-4f2a-b202-5c23af9d7127");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d293ac5-4a19-4694-8274-e9081f1aa899");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adf7dec8-c439-4d1e-b71e-4eeffb9a7af9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c40a8ca1-3b33-4242-a4c1-8ebd77a26dad");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "02ccf2e9-f1b2-4945-ae61-6a8b120e2375", 0, "a250609d-4e00-45c3-a056-eec794325c90", "user1@test.com", false, false, null, "User01", "USER1@TEST.COM", "USER1@TEST.COM", "AQAAAAIAAYagAAAAEH2UXUo/6QmjJrV12Qlr5htcA9NgpKDgn7ZsiqxJcapQ4E8yKT7TOH9pgJE6PBs2ag==", null, false, "1563ee01-469c-40e9-8465-c36a3b92337d", 1, false, "user1@test.com" },
                    { "435a6274-6ea1-4f2a-b202-5c23af9d7127", 0, "b3249088-72b7-48d6-9d3a-1dee016167dd", "user2@test.com", false, false, null, "User02", "USER2@TEST.COM", "USER2@TEST.COM", "AQAAAAIAAYagAAAAEMzJFYfL4segGt+PVzikqY8qCqGOc2WzdAs1BkCTSADCMBcz9QzS5GlVw3athl73BA==", null, false, "9fa1a729-e888-4c58-a59f-9f03c62b40c6", 1, false, "user2@test.com" },
                    { "4d293ac5-4a19-4694-8274-e9081f1aa899", 0, "38b9ec6e-3fdd-4b26-b71c-5850c67a8cf1", "user3@test.com", false, false, null, "User03", "USER3@TEST.COM", "USER3@TEST.COM", "AQAAAAIAAYagAAAAEJ1pjuRaRXBnbIk/WRIQVlKKnnZ4IXLXQkQauwx11bStuFHWrfIUQlvcUGwvbgyUgw==", null, false, "cba5e2f5-9a06-46f3-858b-ffd06bd47f37", 1, false, "user3@test.com" },
                    { "adf7dec8-c439-4d1e-b71e-4eeffb9a7af9", 0, "af03fb15-e699-484c-b4eb-1ea95d74b7f0", "admin@test.com", false, false, null, "Admin", "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAIAAYagAAAAELacwTL6g1DiL0mi0dmLCUYexvwkS8JdG8XV3S7T6MneNnmPNo7Cpn6Uw7OOVaLWFQ==", null, false, "6682021d-eb2f-472f-b224-85fa7a525504", 0, false, "admin@test.com" },
                    { "c40a8ca1-3b33-4242-a4c1-8ebd77a26dad", 0, "9c814822-5d67-4635-b971-bc29b500a3a3", "amisha@gmail.com", false, false, null, "Amisha", "AMISHA@GMAIL.COM", "AMISHA@GMAIL.COM", "AQAAAAIAAYagAAAAELOzvWoziOSnTTWTk1XgWVX14XQ78HKqa6msHjuwy6AoCbzFHwbsP+HhRT5D5byGew==", null, false, "9ffa3cb6-7537-4305-8c15-c4e4eff06b15", 1, false, "amisha123" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CurrentlyBorrowedByUserId", "Description", "FeaturedImageUrl", "IsAvailable", "LentByUserId", "Name", "Ratings", "UrlHandle" },
                values: new object[,]
                {
                    { new Guid("0f4461bb-8066-43ec-b250-9d721436fde0"), "Bhagat Singh", null, " Bhagat Singh's Jail Diary is a poignant and thought-provoking collection of writings penned by the Indian revolutionary during his imprisonment in Lahore Central Jail from 1929 to 1931. It offers a glimpse into his mind and soul, revealing his deep love for his country, his unwavering commitment to social justice, and his unwavering belief in the power of revolution.  The diary is a tapestry of personal reflections, political treatises, and literary musings, reflecting Singh's multifaceted personality and his wide-ranging intellectual interests. He delves into topics such as imperialism, capitalism, socialism, atheism, and religion, engaging with the ideas of prominent thinkers like Karl Marx, Vladimir Lenin, and Fyodor Dostoevsky.  Singh's writings are characterized by their clarity, passion, and sincerity. He fearlessly exposes the injustices of British rule in India and the plight of the oppressed masses. He calls for a radical transformation of society, advocating for a classless, egalitarian society based on the principles of socialism and communism.  The Jail Diary is not just a historical document; it is a testament to the indomitable spirit of a young man who dared to challenge the status quo and fight for a better world. It continues to inspire and challenge readers, reminding us of the power of individual action and the importance of fighting for what is right.", "https://m.media-amazon.com/images/I/51h5ch+vZIL.jpg", true, "adf7dec8-c439-4d1e-b71e-4eeffb9a7af9", "Jail Diary", 0.0, "Jail Diary By Bhagat Singh" },
                    { new Guid("32769abb-94ae-4577-91c5-db857e13810d"), "J.K Rolling", null, "Harry Potter and the Sorcerer's Stone, also known as Harry Potter and the Philosopher's Stone outside of the United States, is a fantasy novel written by British author J. K. Rowling. The novel chronicles the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are first-year students at Hogwarts School of Witchcraft and Wizardry. The story covers Harry's first discovery of his magical heritage, his enrollment at Hogwarts, his making of close friends and enemies, and his confrontation with the dark wizard Lord Voldemort. The novel was first published in the United Kingdom by Bloomsbury Ltd. on 26 June 1997.\r\n\r\nA lonely orphan living with his unwelcoming aunt, uncle, and cousin, Harry Potter learns on his eleventh birthday that he is an orphaned wizard and is famous throughout the wizarding world as the boy who survived the attack by Lord Voldemort, a powerful dark wizard who killed Harry's parents in their attempt to thwart his bid for power. Harry is summoned from his life as an unwanted child by his parents' friend Rubeus Hagrid, a giant and Hogwarts' Keeper of Keys and Grounds, who reveals to him that he is a wizard and has been accepted at Hogwarts School of Witchcraft and Wizardry.\r\n\r\nAt Hogwarts, Harry is sorted into Gryffindor House and befriends Ron Weasley and Hermione Granger. Together, they learn about magic, defend themselves from dark creatures, and uncover a plot by Voldemort, who has returned to power and is hiding within the school, to steal the Sorcerer's Stone, a powerful object that would grant him immortality.", "https://images.pexels.com/photos/8391515/pexels-photo-8391515.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", true, "adf7dec8-c439-4d1e-b71e-4eeffb9a7af9", "Harry Potter", 0.0, "Harry Potter and the Sorcerer's Stone" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "UrlHandle" },
                values: new object[,]
                {
                    { new Guid("4f51de1c-4b16-456b-aa60-8ad0f45a37b8"), "Novel", "/Novel" },
                    { new Guid("4f6de814-a6fd-4561-b807-06f4922bfa97"), "Others", "/Others" },
                    { new Guid("54007cfd-68de-4dcb-84e5-e96f4b60e91f"), "Fantasy", "/Fantasy" },
                    { new Guid("dffb2735-2de2-46d8-b957-f986cdb4f08f"), "Science Fiction", "Science Fiction" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "02ccf2e9-f1b2-4945-ae61-6a8b120e2375" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "435a6274-6ea1-4f2a-b202-5c23af9d7127" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "4d293ac5-4a19-4694-8274-e9081f1aa899" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "adf7dec8-c439-4d1e-b71e-4eeffb9a7af9" },
                    { "95cb1e1c-d8b6-45a2-b240-6d211c06fd00", "adf7dec8-c439-4d1e-b71e-4eeffb9a7af9" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "c40a8ca1-3b33-4242-a4c1-8ebd77a26dad" }
                });
        }
    }
}
